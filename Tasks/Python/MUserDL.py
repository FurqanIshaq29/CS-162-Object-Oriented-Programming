import os.path
from MUser import MUser

class MUserDL:
    userList = []

    @staticmethod
    def addUserToList(user):
        MUserDL.userList.append(user)

    @staticmethod
    def SignIn(user):
        for i in MUserDL.userList:
            if (i.userName == user.userName and i.userPassword == user.userPassword):
                return i
        return None

    @staticmethod
    def parseData(line):
        line = line.split(",")
        return line[0], line[1], line[2]

    @staticmethod
    def readDataFromFile(path):
        if (os.path.exists(path)):
            fileVariable = open(path, 'r')
            records = fileVariable.read().split("\n")
            fileVariable.close()
            for line in records:
                userName, userPassword, userRole = MUserDL.parseData(line)
                user = MUser(userName, userPassword, userRole)
                MUserDL.addUserToList(user)
            return True
        else:
            return False

    @staticmethod
    def storeUserIntoFile(user, path):
        file = open(path, 'a')
        file.write("\n"+ user.userName + "," + user.userPassword + "," + user.userRole)
        file.close()
