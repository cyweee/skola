# This script takes the specified images and saves them into a single PDF file, where each image is a separate page
# saved here for my personal use
# requirements -- `pip install img2pdf`


import img2pdf

files = ["screenshot1.png", "screenshot2.png", "screenshot3.png"]

with open("output.pdf", "wb") as f:
    f.write(img2pdf.convert(files))

