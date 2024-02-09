from MUserDL import MUserDL
from MUserUI import MUserUI
import os
from time import sleep

def main():
    path = "Data.txt"
    MUserDL.readDataFromFile(path)
    option = 0
    while (option != 3):
        os.system("cls")
        option = MUserUI.menu()
        if (option == 1):
            user = MUserUI.takeInputwithOutRole()
            user = MUserDL.SignIn(user)
            if (user != None):
                if (user.isAdmin()):
                    print("This is Admin")
                else:
                    print("This is User")
                sleep(3)
        elif (option == 2):
            user = MUserUI.TakeInputWithRole()
            MUserDL.addUserToList(user)
            MUserDL.storeUserIntoFile(user, path)


if __name__ == "__main__":
    main()
