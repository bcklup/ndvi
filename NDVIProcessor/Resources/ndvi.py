import cv2
import sys, getopt
import numpy as np

def main(argv):

    nirfile = ''
    redfile = ''
    outputfile = ''
    
    try:
        opts, args = getopt.getopt(argv,"hn:r:o:",["nfile=","rfile=","ofile="])
    except getopt.GetoptError:
        print('test.py -n <nirfile> -r <redfile> -o <outputfile>')
        sys.exit(2)
    for opt, arg in opts:
        if opt == '-h':
            print('test.py -n <nirfile> -r <redfile> -o <outputfile>')
            sys.exit()
        elif opt in ("-n", "--nfile"):
            nirfile = arg
        elif opt in ("-r", "--rfile"):
            redfile = arg  
        elif opt in ("-o", "--ofile"):
            outputfile = arg 
  
    nir = cv2.imread(nirfile,0)
    red = cv2.imread(redfile,0)

    np.seterr(invalid='ignore')

    ndvi = (nir-red)/(nir+red)

    print(ndvi)

    cv2.imwrite(outputfile,ndvi)
    reload = cv2.imread(outputfile,0)
    reload = cv2. applyColorMap(reload,4)
    cv2.imwrite(outputfile,reload)

if __name__ == "__main__":
   main(sys.argv[1:])