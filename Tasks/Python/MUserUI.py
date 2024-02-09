from MUser import MUser
from MUserDL import MUserDL
class MUserUI:

    @staticmethod
    def menu():
        print("1. SignIn")
        print("2. SignUp")
        print("Enter Option")
        option  = int(input())
        return option
    
    @staticmethod
    def printList(userList):
        for user in userList:
            print(user.userName,user.userPassword,user.userRole)


    @staticmethod
    def TakeInputWithRole():
        userName = input("Enter UserName : ")
        userPassword = input("Enter UserPassword : ")
        userRole = input("Enter UserRole : ")
        user = MUser(userName, userPassword, userRole)
        return user
    
    @staticmethod
    def takeInputwithOutRole():
        userName = input("Enter UserName : ")
        userPassword = input("Enter UserPassword : ")
        user = MUser(userName, userPassword, None)
        return user