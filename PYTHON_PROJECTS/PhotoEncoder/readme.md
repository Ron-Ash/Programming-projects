# Photo Encoder

A program which can encrypt either a photo (will be translated into black and white) or a piece of text within a 'base' photo. I created this project after being introduced to the concept of cybersecurity and cryptography.
- python

pathways used can be either absolute or relative

## Development Environment:
1. Download Python
2. Clone the repository:
``` > git clone https://github.com/Ron-Ash/Programming-projects```
3. browse to the folder ```PYTHON_PROJECTS/PhotoEncoder```
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

## Example run:
The resulting photos are from an example run where a photo was encoded into another
- 'Base' Image ![image](https://user-images.githubusercontent.com/37012505/215311290-65c37f9d-7073-4a71-aa92-3e3b13123355.png)
- Photo to be encrypted ![image](https://user-images.githubusercontent.com/37012505/215311472-b9ea46c9-110a-4833-b0f3-37033f397b83.png)
- the resulting 'merged' photo with the encrypted secret photo ![image](https://user-images.githubusercontent.com/37012505/215311521-9fbe17fc-add1-496d-8e74-aa9febb970d3.png)
- the retrieved photo after the 'merged' photo was decrypted ![image](https://user-images.githubusercontent.com/37012505/215311539-cbb39507-24e6-4ed9-b6cd-1aefae754eaa.png)
