from UI.AgendaController import *

class AgendaUI:
    def __int__(self):
        pass
    def PrintMenu(self):
        """
            Show the MainMenu
        """
        print """--------------------
        MENU
--------------------
1. ADD CONTACT
2. SEARCH CONTACT
3. SEARCH GROUP
4. EXPORT TO A FILE
0. EXIT"""
        i=input('Operation:')
        while i<0 or i>4:
            print "WRONG OPERATION!"
            i=input('New operation:')
        return i
    def add(self):
        """
            Add a new contact to the database
        """
        ac=AgendaController()
        name=raw_input('    Name:').strip()
        ok=False
        while ok==False:
            ok=True
            try:
                id=int(raw_input('    ID:'))
            except ValueError:
                print "Give a numerical ID"
                ok=False
        nr=raw_input('    Phone Number:').strip()
        group=raw_input('    Group:').strip()
        i=ac.addContact(id,name,nr,group)
        if i==False:
            print "INVALID CONTACT!!!"
            self.add()
    def find(self):
        """
            Find a contact by it's name
        """
        ac=AgendaController()
        name=raw_input('NAME:').strip()
        contact=ac.lookup(name)
        if contact==False:
            print "CONTACT NOT FOUND"
        else:
            print 'Phone Number:',contact.getPhoneNr()
    def showGroup(self):
        """
            Show all the contacts from the group
        """
        ac=AgendaController()
        group=raw_input('Group:').strip()
        while group<>'Family' and group<>'Friends' and group<>'Others':
            print 'INVALID GROUP'
            group=raw_input('Group:').strip()
        list=ac.lookUpAll(group)
        if list==[]:
            print 'EMPTY GROUP'
        else:
            for i in list:
                print i.getName(),': ',i.getPhoneNr()

    def addToFile(self):
        """
            Save the name and the number of the contacts to a text file
        """
        ac=AgendaController()
        group=raw_input('Group:').strip()
        while group<>'Family' and group<>'Friends' and group<>'Others':
            print 'INVALID GROUP'
            group=raw_input('Group:').strip()
        list=ac.lookUpAll(group)
        outFile=raw_input('FileName:').strip()
        try:
            ac.exportCSV(group, outFile)
        except IOError:
            print "File not found"

    def run(self):
        """
            Run the applicaion
        """
        i=self.PrintMenu()
        while i<>0:
            commands=[self.add, self.find,self.showGroup,self.addToFile]
            commands[i-1]()
            i=self.PrintMenu()
        print 'Have a nice day :)'

def testAgendaUI():
    aui=AgendaUI()
    aui.run()
testAgendaUI()