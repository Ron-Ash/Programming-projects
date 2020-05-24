import random
tenToTwelve = ['RATCLIFF, Oscar (oratc0) <oratc0@eq.edu.au>', 'FERREIRA, Alexander (aferr70) <aferr70@eq.edu.au>', 'HEDGES, Connor (chedg13) <chedg13@eq.edu.au>' , 'JONES, Jack (jjone500) <jjone500@eq.edu.au>']
sevenToNine = ['CRAFT, Matthew (mcraf4) <mcraf4@eq.edu.au>', 'DRAGE, Benji (bdrag4) <bdrag4@eq.edu.au>', 'PETRUSHIN, Victor (vpetr7) <vpetr7@eq.edu.au>', 'CHERRY, Jade (jcher46) <jcher46@eq.edu.au>', 'DAVEY, Zaisha (zdave11) <zdave11@eq.edu.au>', 'ODONOVAN, Brooke (bodon44) <bodon44@eq.edu.au>', 'ADAMS, Reilly (radam157) <radam157@eq.edu.au>', 'HORTON, Flynn (fhort0) <fhort0@eq.edu.au>', 'TATZENKO, Daniel (dtatz1) <dtatz1@eq.edu.au>', 'ROGERS, Elliott (eroge63) <eroge63@eq.edu.au>', 'REVESZ, Lily (lreve0) <lreve0@eq.edu.au>', 'MOORE, Tyler (tmoor163) <tmoor163@eq.edu.au>', 'WOLSKI, Merrick (mwols9) <mwols9@eq.edu.au>', 'OZOLINS, Thomas (tozol0) <tozol0@eq.edu.au>', '']

print('7-9:\t')
for i in range(5):
    print(random.choice(sevenToNine))


print('\n10-12:\t')
for i in range(5):
    print(random.choice(tenToTwelve))

print(len(sevenToNine), len(tenToTwelve))