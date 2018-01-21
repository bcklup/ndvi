import cv2
import sys, getopt
import numpy as np

def main(argv):

    nirfile = ''
    rgbfile = ''
    outputfile = ''
    cmap = ''
    try:
        opts, args = getopt.getopt(argv,"hn:r:o:c:",["nfile=","rfile=","ofile=","cmap="])
    except getopt.GetoptError:
        print('test.py -n <nirfile> -r <rgbfile> -o <outputfile> -c <colormap mode 0-12>')
        sys.exit(2)
    for opt, arg in opts:
        if opt == '-h':
            print('test.py -n <nirfile> -r <rgbfile> -o <outputfile> -c <colormap mode 0-12>')
            sys.exit()
        elif opt in ("-n", "--nfile"):
            nirfile = arg
        elif opt in ("-r", "--rfile"):
            rgbfile = arg  
        elif opt in ("-o", "--ofile"):
            outputfile = arg 
        elif opt in ("-c", "--cmap"):
            cmap = arg
    nir = cv2.imread(nirfile,1)
    red = cv2.imread(rgbfile,1)
    
    bgmap = cv2.applyColorMap(nir,int(cmap))
    nir = nir-red
    temp = cv2.split(red)
    red=temp[2]
    
    temp = cv2.split(nir)
    nir = temp[2]

    np.seterr(invalid='ignore')
    ndvi = (nir-red)/(nir+red)

    print(ndvi)

    cv2.imwrite(outputfile,ndvi)
    reload = cv2.imread(outputfile,0)
    reload = cv2. applyColorMap(reload,int(cmap))
    reload = cv2.addWeighted(bgmap,0.5,reload,0.5,0.0)
    cv2.imwrite(outputfile,reload)

if __name__ == "__main__":
   main(sys.argv[1:])