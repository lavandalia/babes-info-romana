'''
Created on 8 dec. 2014

@author: teo
'''
from domain.filme import Film
from repository.repo import RepoFilme


class Validator():
    '''
    clasa care valideaza un obiect de tip Film
    '''
        
    
    def validare(self, film):
        '''
        metoda ce verifica da
        ca entitatea Film:
        '''  
        msg = []
        
        if len(film.getTitlu()) > 30:
            msg.append("Numele este prea lung.")
        if film.getPret() < 10 or film.getPret() > 20:
            msg.append("Pretul trebuie sa fie intre 10 si 20.")
        if film.getNrLocuri() < 0 or film.getNrLocuri() > 100:
            msg.append("Numarul de locuri trebuie sa fie intre 0 si 100.")
        
        if len(msg) > 0:
            raise ValueError(msg)


def testValidare():
    valid = Validator()
    fi = Film(47, 'De la speciifklajsssssssssssssss', 15, 68)
    try:
        valid.validare(fi)
        assert False
    except ValueError:
        assert True
        
testValidare()