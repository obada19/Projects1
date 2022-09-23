import csv
from math import radians, cos, sin, asin, sqrt, log

# here we are openeing the csv
reader = csv.reader(open(r'C:\\Users\\obada\\Downloads\\worldcities.csv', encoding="utf8"))
# initializing an empty list
latitudelistofcities = []
# new list to have the numbers that we are going to sort
newlist = []
# this list is to be used in sub quistion 3
newlist2 = []
# taking only the values of the latitude
for row in reader:
    latitudelistofcities.append(row[2])
# removing the header name from the list
latitudelistofcities.remove('lat')
# turning the list from string to float
for i in latitudelistofcities:
    s = float(i)
    newlist.append(s)
    newlist2.append(s)
# it was dicided to do everything in one function instead of two
counter = 0
counter1 = 0
def mergesorting(list):
    global counter1
    if len(list) <= 1:
        return list
    else:
        mid = len(list)//2
        leftside = list[:mid]
        rightside = list[mid:]
        mergesorting(leftside)
        mergesorting(rightside)
        counter1 +=1
        # we need variables to go through the lists
        # l for the left side
        l = 0
        # r for the right side
        r = 0
        # m for the main list
        m = 0
        # iterating until the we reach the end of both left and right side lists
        #counter for the number of merges needed
        global counter
        while l < len(leftside) and r < len(rightside):
            # if the left is smaller
            if leftside[l] < rightside[r]:
                # we put the left in the main list
                list[m] = leftside[l]
                # we add 1 to left
                l += 1
                counter += 1
            else:
                # if the right is smaller we add the right to the main list
                list[m] = rightside[r]
                # we add one to the right iterator
                r += 1

                counter +=1
                # we add on to the main list at both conditions
            m += 1
            # we need to add the resting elements in the array when the comparison is done
        while l < len(leftside):
            list[m] = leftside[l]
            l+= 1
            m+=1
            counter+=1
        while r < len(rightside):
            list[m] = rightside[r]
            r+= 1
            m+=1
            counter+=1
#applying the function and printing it
mergesorting(newlist)

# quistion 2 answer

# this is the number of merges needed formula
#s = log^2*len(newlist2)


# no because it will still follow the same rules which means it will divide all the items in the list into atomic elements and
# after that it will start comating and merging the elements which will result in the same value.

#3
# using the haversine formula to calculate the distance from the [0,0] to all the lat and long in order to sort the list
# Distance between two lat/lng coordinates in km using the Haversine formula
def getDistanceFromLatLng(lat1, lng1, lat2, lng2, miles=False): # use decimal degrees
  r=6371 # radius of the earth in km
  lat1=radians(lat1)
  lat2=radians(lat2)
  lat_dif=lat2-lat1
  lng_dif=radians(lng2-lng1)
  a=sin(lat_dif/2.0)**2+cos(lat1)*cos(lat2)*sin(lng_dif/2.0)**2
  d=2*r*asin(sqrt(a))

  if miles:
    return d * 0.621371 # return miles
  else:
    return d # return km



reader = csv.reader(open(r'C:\\Users\\obada\\Downloads\\worldcities.csv', encoding="utf8"))
# initializing an empty list
longtitudeList = []
# new list to have the numbers
newlist1 = []
# taking only the values of the latitude
for row in reader:
    longtitudeList.append(row[3])
longtitudeList.remove("lng")
for i in longtitudeList:
    s = float(i)
    newlist1.append(s)
# make both in one list

listOfLatitude_And_longtitude = [list (s) for s in zip(newlist2, newlist1) ]

mergesorting(listOfLatitude_And_longtitude)
temp= []
for i in listOfLatitude_And_longtitude:
   s =  getDistanceFromLatLng(i[0],i[1], 0, 0)
   temp.append(s)


list_to_USE_in_sorting= [list (j) for j in zip(temp, listOfLatitude_And_longtitude)]

mergesorting(list_to_USE_in_sorting)

# make sorting way and find what to sort for
count = 0
for i in list_to_USE_in_sorting:
    for g in i[::2]:
        i.remove(g)

# here we turned the two values into one using harvesine formula in order to have an order to sort to in the list
# next we calculated the distance from the equador which is [0,0] in the longtitude and latitude to the long\latitude that we have
# for each city
# after calculating that number we added that number to make a nested list and then did merge sorting on the distance that we calculated
# using the priveous function.
# after acquring an ordered list we removed the distance that we caluculated from the harvesine formula and had only the ordered list
print("this is the sorted list", list_to_USE_in_sorting)
print(len(list_to_USE_in_sorting))


