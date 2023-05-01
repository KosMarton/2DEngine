def startend(func):
    print("start")
    func()
    print("end")

@startend
def func1():
    print("I'm func1!")

func1()