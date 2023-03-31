# HomeAssistant_APC_SNMP_Auto_Config

*Work in progress*

This is planed to allow for quick configuration of old APC Switched PDUs for Home Assistant. The project is currently in a closed development. hopefully the project can be made into a Home Assistant Add-on,  **still in progress**.

Also If you have any sugjestions please share, this is my first big prodect coding in C#.


## Why Not Do It Manually?

The problem I was running it to when typing out the code was that with multible lage PDUs the code becomes messy and its time consuming to add.

![image](https://user-images.githubusercontent.com/54962602/229191086-89ab3b4d-a387-4b3e-ac52-bb2bf7249c03.png)

*Code For only 3 plugs*

## How Does It Work?

I wanted to keep it simple so it currently only outputs the raw code. that code can then be copied and pasted into you're config file in home assistant. make sure that the conde is pased in the switches category as shown above. The program once lanched asks for the **IP of the divice, the Number of outlets/ports, and you're naming**
*note the code will add a corasponding number to each plug* ex: name = plug   code = Plug1, Plug2.
![image](https://user-images.githubusercontent.com/54962602/229200087-2847b691-9647-4196-877d-327fa6e8600a.png)

