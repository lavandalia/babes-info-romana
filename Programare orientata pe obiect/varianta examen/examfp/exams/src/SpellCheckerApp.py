'''
Created on Jan 23, 2013

@author: Maria
'''
from Repository.WordsRepository import WordsRepository
from UI.SpellCheckerController import SpellCheckerController
from UI.SpellCheckerUI import SpellCheckerUI

repo=WordsRepository("D:\examfp\exams\src\dictionary.txt")
ctrl=SpellCheckerController(repo)
ui=SpellCheckerUI(ctrl)

ui.Main()