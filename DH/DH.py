g = 2
p = 2410312426921032588552076022197566074856950548502459942654116941958108831682612228890093858261341614673227141477904012196503648957050582631942730706805009223062734745341073406696246014589361659774041027169249453200378729434170325843778659198143763193776859869524088940195577346119843545301547043747207749969763750084308926339295559968882457872412993810129130294592999947926365264059284647209730384947211681434464714438488520940127459844288859336526896320919633919
a = 1101001010019203192312312312435234234131235457686756554434232325365645342323243
b = 2343423432473984729384792837492837498273984739847982


def power(x, y, p):
    res = 1
    x = x % p
    if x == 0:
        return 0
    while y > 0:
        if (y & 1) == 1:
            res = (res * x) % p
        y = y >> 1
        x = (x * x) % p
    return res


def remainder(st):
    ln = len(st)
    rem = 0
    for i in range(0, ln):
        num = rem * 10 + int(st[i])
        rem = num % p
    return rem


def user1_A(a):
    global A
    A = int(power(g, a, p))
    print('A equals : ', A)


def user2_B(b):
    global B
    B = int(power(g, b, p))
    print('B equals : ', B)


def user1_s(a):
    s = int(power(B, a, p))
    print("Secret key for user 1 is :", s)


def user2_s(b):
    s = int(power(A, b, p))
    print("Secret key for user 2 is :", s)


user1_A(a)
user2_B(b)

user1_s(a)
user2_s(b)

# print(B , A)
