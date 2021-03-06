import cv2
import sys, getopt
import numpy as np

def main(argv):

    nirfile = ''
    rgbfile = ''
    outputfile = ''
    try:
        opts, args = getopt.getopt(argv,"hn:r:o:c:",["nfile=","rfile=","ofile="])
    except getopt.GetoptError:
        print('test.py -n <nirfile> -r <rgbfile> -o <outputfile>')
        sys.exit(2)
    for opt, arg in opts:
        if opt == '-h':
            print('test.py -n <nirfile> -r <rgbfile> -o <outputfile>')
            sys.exit()
        elif opt in ("-n", "--nfile"):
            nirfile = arg
        elif opt in ("-r", "--rfile"):
            rgbfile = arg  
        elif opt in ("-o", "--ofile"):
            outputfile = arg 
    nir = cv2.imread(nirfile,0)

    nir2 = cv2.imread(nirfile,1)
    red = cv2.imread(rgbfile,1)
    
    bgmap = cv2.applyColorMap(nir,1)
    nir2 = nir2-red
    temp = cv2.split(red)
    red=temp[2]
    
    temp2 = cv2.split(nir2)
    nir2 = temp2[2]

    np.seterr(invalid='ignore')
    ndvi = (nir-red)/(nir+red)
    ndvi2 = (nir2-red)/(nir2+red)
    rawtext = cv2.countNonZero(ndvi2)*0.000035
    ndvitext = float("{0:.2f}".format(rawtext))
    print("NDVI Ratio: "+str(cv2.countNonZero(ndvi2)*0.00000035)+ "\nOverall Percentage: "+str(ndvitext) + "%")
    
    cv2.imwrite(outputfile,ndvi)
    reload = cv2.imread(outputfile,0)
    reload = cv2. applyColorMap(reload,11)
    reload = cv2.addWeighted(bgmap,0.3,reload,0.7,0.0)
    cv2.imwrite(outputfile,reload)

if __name__ == "__main__":
   main(sys.argv[1:])