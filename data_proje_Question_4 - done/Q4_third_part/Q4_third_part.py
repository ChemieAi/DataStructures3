import networkx as nx
import networkx.exception
import matplotlib.pyplot as plt

x = int(input("Please enter the starting node :"))
y = int(input("Please enter the end node  :"))

G1=nx.DiGraph()
G1.add_node(0,pos=(0,0))
G1.add_node(1,pos=(2,-1))
G1.add_node(2,pos=(1,-2))
G1.add_node(3,pos=(-1,-2))
G1.add_node(4,pos=(-2,-1))

G1.add_edge(0,4, weight = 2.0)
G1.add_edge(0,2, weight = 3.0)
G1.add_edge(0,1, weight = 5.0)
G1.add_edge(1,2, weight = 2.0)
G1.add_edge(1,3, weight = 6.0)
G1.add_edge(2,1, weight = 1.0)
G1.add_edge(2,3, weight = 2.0)
G1.add_edge(4,1, weight = 6.0)
G1.add_edge(4,2, weight = 10.0)
G1.add_edge(4,3, weight = 4.0)
Pos = nx.circular_layout(G1)
labels = nx.get_edge_attributes(G1,'weight')
nx.draw_networkx_edge_labels(G1,Pos,edge_labels=labels)
G1.remove_node(1)
nx.draw_networkx(G1, with_labels=True)

try:
    f = (nx.dijkstra_path(G1, x, y))
    print(f)
    if len(f) == 2:
        path1 = labels[f[0], f[1]]
        print("shortest path's length :", path1)
    else:
        path1 = labels[f[0], f[1]]
        path2 = labels[f[1], f[2]]
        print("shortest path's length :", path1 + path2)

except:
    print("Oops!", networkx.exception.NetworkXNoPath, "occured.")
    print("THERE'S NO PATH TO" , y, "FROM THIS STARTING NODE")
    print()

plt.show()
