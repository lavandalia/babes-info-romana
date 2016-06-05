'''
Created on Jan 23, 2013

@author: Maria
'''
from SpellCheckerController import SpellCheckerController
class SpellCheckerUI:
    def __init__(self,control):
        self.__control=control
        
    def Main(self):
        print "1 add new word"
        print "2 check text"
        print "3 check a text file"

        
        while 1:
            cmd=raw_input("give command")
            if cmd=="1":
                id=raw_input("give id")
                lang=raw_input("give language")
                nword=raw_input("give word")
                print self.__control.addWord(id,lang,nword)
                
            elif cmd=="2":
                lang=raw_input("what language?")
                text=raw_input("give the text")
                newWords=self.__control.check(lang,text)
                for i in range(0,len(newWords)):
                    print newWords[i]
                    #print "\n"
            elif cmd=="3":
                lang=raw_input("what language?")
                self.__control.check2("D:\examfp\exams\src\words.txt",lang,"D:\examfp\exams\src\exists.txt")
            
            elif cmd=="4":
                lang=raw_input("what language?")
                inFile=str(raw_input("form file:"))
                outFile=str(raw_input("to file:"))
                self.__control.check2(inFile,lang,outFile)
                       
            elif cmd=="p":
                wordlist=self.__control.getList()
                for i in range(0,len(wordlist)):
                    print wordlist[i]
            elif cmd=="q":
                break