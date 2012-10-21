A full tutorial [is here](http://webservices20.blogspot.co.il/2008/11/introducing-wcf-clearusernamebinding.html).

You can also check [my twitter](https://twitter.com/YaronNaveh).

## ClearUsernameBinding

Wcf does not natively allow to send username token over an unsecured transport (namely non-ssl). Trying to do so will results in one out of many errors, typically this one:


`````
The provided URI scheme 'http' is invalid; expected 'https'. Parameter name: via
`````

In some cases this is a legitimic use case. Consider the use of a load balancer, or an internal secured network.

ClearUsernameBinding allows to do this using a very simple configuration.


**How to use ClearUsernameBinding?**

A full tutorial [is here](http://webservices20.blogspot.co.il/2008/11/introducing-wcf-clearusernamebinding.html).
