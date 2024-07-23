---
layout: post
title:  "Common Linux termnal commands"
description: "Here is a list of commonly used Linux terminal commands"
categories: quickreference
order: 51
---
<script src="https://gist.github.com/rxaviers/7360908.js"></script>

### Favorite Linux commands
* `cd [directory]` - *Change directory.
This command can also be used double dots to go back one level `cd ..` or with dash `cd -` to go back to previous directory. `cd ~` or `cd ` to get to HOME directory and `cd /` to get to root directory.*
* `mkdir [directory]` -*Make directory*
* `rm [file | directory]` removes a file of directory. If the directory is not empty. use the recursive flag `-r`
* `CTRL+l` -*Clear screen*
*`CTRL+r` -*Find a previous command*
*Hit `CTRL+r` and start typing to find a command you have used before*
* `whoami` -*Show the current user*
* `sudo [command]` -*Run command as root*
* `sudo su` -*Change user to `root`*
* `find -name [name of file]` -*Find a file by name*
* `grep -R ./ -e "[seach pattern]"` -*find files containing a word or pattern* 
* `cat [file name]` -*View content of file*
* `df -h` -*shows available and used disk space on the Linux system*
* `chmod +x [file name]` -*Makes file executable*
* `grep` - is used to filter output such as `df -h | grep udev` returns only one row from the `df` command
* `asw` - spits an input into an array. For instance `df -h | grep udev | awk '{print $2}'` returns only the second column.

**grep and awk** sample 
```
$ df -h
Filesystem      Size  Used Avail Use% Mounted on
udev            315M     0  315M   0% /dev
tmpfs            91M  1.2M   90M   2% /run
/dev/mmcblk0p2   29G  4.8G   22G  18% /
tmpfs           454M  8.0K  454M   1% /dev/shm
tmpfs           5.0M   12K  5.0M   1% /run/lock
/dev/mmcblk0p1  510M   75M  436M  15% /boot/firmware
tmpfs            91M   44K   91M   1% /run/user/1000

 $ df | grep udev
udev              322452       0    322452   0% /dev

$ df | grep udev | awk '{print $2}'
322452
```

### Favorite **vi** commands
*`vi` or `vim` is a commonly used file editor, which can be complex to use, but here are a few commands to get you started.*

* To open a file with `vi`, type `vi [file name]`
* To edit the content, hit `i`
* To delete a row, hit `d+d`
* To leave a mode (such as edit), hit `ESC+ESC`
* To save your changes, hit `w`
* To quit `vi`, hit `w` or `wq` to save and quit

### Favorite **less** commands
*`less` is a great tool for analyzing log files.*

* Open a log file, use `sudo less /var/log/syslog`. Use the `-S` flag to wrap long lines`
* Use `b` to go backward one window
* Use `f` to go forward one window
* Use `G` to go to the end of file
* Use `g` to go to the beginning of file
* Use `/` to search forward
* Use `?` to search backward

### Favorite **systemctl** commands
`systemd` is a software suite that provides an array of system components for Linux operating systems, such as daemons (services). `systemctl` is the tool you use to interact with `systemd`

* `systemctl start [daemon]` starts a daemon
* `systemctl stop [daemon]` stops a daemon
* `systemctl restart [daemon]` re-starts a daemon
* `systemctl cat [daemon]` view the service file
* `systemctl daemon-reload` applies changes made to any service file.

### Favorite **journalctl** commands
`journalctl` is also part of the `systemd` suite and helps you view logfile in real-time.

`journalctl -u [service] -n [number of previous lines] -f` . E.g.
```
journalctl -u microservicebus-node -n 100 -f
``` 

