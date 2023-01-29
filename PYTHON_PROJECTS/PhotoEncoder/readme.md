# Photo Encoder

A program which can encrypt either a photo or a piece of text within a 'base' photo. I created this project after being introduced to the concept of cybersecurity and cryptography.
- python

## Development Environment:
1. Download Python
2. Clone the repository:
``` > git clone https://github.com/Ron-Ash/MicroControllerProject```
3. Choose a photo to be the 'base' as well as the one you would like to encrypt (make sure both are .png)
4. Open ```PhotoEncoder.py``` in your script editor
5. write the 'base' photo's pathway into ```Image1```
6. follow one of the paths below
7. run script

### Encrypt Photo:   
1. write the pathway of the photo you would like to encrypt into ```Image2```
2. write the pathway of where you would like the result to be into ```Image3```
3. uncomment ```EncodeInImage(Image1, BlackAndWhite(Image2, Image1))```
    
### Decrypt Photo:
1. write the pathway where the encoded photo is in ```Image3``` 
2. uncomment ```RetriveSecretImage(Image1, Image3)```
    
### Encrypt Text:
1. write the text you would like to encrypt in ```text```
2. write the pathway of where you would like the result to be into ```Image3```
3. uncomment ```EncodeInImage(Image1,EncodeText(list(text)))```

### Decrypt Text:
1. write the pathway where the encoded photo is in ```Image3```
2. uncomment ```RetriveSecretText(Im.open(Image1), Im.open(Image3))```