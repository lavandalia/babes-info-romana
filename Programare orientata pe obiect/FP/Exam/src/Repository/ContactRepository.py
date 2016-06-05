from Domain.Contact import *
from Domain.Validator import *

class ContactRepository:
    def __init__(self):
        """
            Initialize the contatct's database
            read in from a textfile the old contacts
        """
        self.__List=[]
        f=open('D:\FP\Exam\contacts.txt','r')
        all=f.read()
        lines=all.split('\n')
        for line in lines:
            if line<>'':
                attribute=line.split(',')
                id=int(attribute[0])
                name=attribute[1]
                tel=attribute[2]
                gr=attribute[3]
                v=Validator()
                c=Contact(id,name,tel,gr)
                try:
                    self.__List.append(c)
                except ValueError:
                    pass
        f.close()
    def save(self):
        """
            Save all the contacts
        """
        f=open('D:\FP\Exam\contacts.txt','w')
        for i in self.__List:
            x=str(i.getID())+','+i.getName()+','+i.getPhoneNr()+','+i.getGroup()
            f.write(x)
            f.write('\n')
        f.close

    def find(self,name):
        """
            Find a contact by name
        """
        for i in self.__List:
            if i.getName()==name:
                return i
        return False

    def add(self,contact):
        """
            Add a new contact to the database
        """
        v=Validator()
        if v.validate(contact)<>False and self.find(contact.getName())==False:
            self.__List.append(contact)
        else:
            raise ValueError('invalid contact')
        self.save()


    def getAll(self):
        """
            Return all the contacts from the repository
        """
        return self.__List
    def getAllGr(self,group):
        """
            Return all the contacts from a chosen group
        """
        list=[]
        for i in self.__List:
            if i.getGroup()==group:
                list.append(i)
        return list

def testContactRepository():
    """
        Test function for the ContactRepository
    """
    cr=ContactRepository()
    cr.add(Contact(1,'Namename','0987','Family'))
    assert cr.find('Name')<>None
    try:
        cr.add(Contact(1,'Name1','0987654321','Friends'))
    except ValueError:
        assert True
    try:
        cr.add(Contact(1,'Name2','','Family'))
    except ValueError:
        assert True
    try:
        cr.add(Contact(1,'Name3','0987654321','vvvfd'))
    except ValueError:
        assert True
    try:
        cr.add(Contact(1,'Name4','abc','Family'))
    except ValueError:
        assert True
    try:
        cr.add(Contact(2,'Name','098897','Family'))
    except ValueError:
        assert True
    list=cr.getAll()
    assert list[0].getID()==1
    assert list[0].getName()=='Name'
    assert len(list)==5
    list2=cr.getAllGr('Family')
    assert len(list2)==2
