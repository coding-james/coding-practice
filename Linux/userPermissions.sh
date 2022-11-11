# Codecademy.com Users & Permissions in Linux

# escalate access to the root
sudo -i

# add marketing, sales and it teams
groupadd marketing-team -f
groupadd sales-team -f
groupadd it-team -f

# verify groups created
cat /etc/group

# add users to groups
useradd james -g marketing-team -m
useradd destiny -g sales-team -m
useradd carolyn -g it-team -m
adduser carolyn sudo
# added to proper group through -g, home directory created since -m flag used

#check home directories for users
ls /home/

#verify user(s) in group(s)
groups james
groups destiny
groups carolyn

# create directories for each dept
wget https://static-assets.codecademy.com/Courses/learn-linux/linux-shell-utilities/project-data.tar.gz

# extract file
tar -xzvf project-data.tar.gz -C /tmp/

# verify files and directories by visualising the directory structure
find /tmp/data | sed -e "s/[^-][^\/]*\// |/g" -e "s/|\([^ ]\)/|-\1/"

# file structure: 
# |-data
# | |-Sales
# | | |-contract_template.txt
# | | |-sales_records.csv
# | |-IT
# | | |-inventory_template.txt
# | | |-all_users.txt
# | |-Marketing
# | | |-social_media_strategy.txt
# | | |-marketing_plan.txt

# modify file permissions for each group
chown :marketing-team /tmp/data/Marketing/
chown :sales-team /tmp/data/Sales/
chown :it-team /tmp/data/IT/

# modify permssion levels for each directory - chmod 774 rwx-rwx-r
chmod -R 774 /tmp/data/Marketing
chmod -R 774 /tmp/data/Sales
chmod -R 774 /tmp/data/IT

# verify
ls /tmp/data -l
# drwxrwxr-- 2 root it-team        4096 Mar  4  2022 IT
# drwxrwxr-- 2 root marketing-team 4096 Mar  4  2022 Marketing
# drwxrwxr-- 2 root sales-team     4096 Mar  4  2022 Sales


# Access Verfication
# Impersonate James and verify access
su james
ls /tmp/data/Marketing
# marketing_plan.txt  social_media_strategy.txt

# Read content of marketing_plan.txt
cat /tmp/data/Marketing/marketing_plan.txt

# attempt to make a modification to file
cat "new data" > /tmp/data/Marketing/marketing_plan.txt
# sh: 4: cannot create /tmp/data/Marketing/marketing_plan.txt: Permission denied

# attempt to read Sales file
ls /tmp/data/Sales
# contract_template.txt  sales_records.csv
cat /tmp/data/Sales/contract_template.txt
# cat: /tmp/data/Sales/contract_template.txt: Permission denied

# change to destiny
# attempt to open a Sales file
cat /tmp/data/Sales/contract_template.txt
# SUCCESS

# attempt to open a Marketing file
cat /tmp/data/Marketing/social_media_strategy.txt
# cat: /tmp/data/Marketing/social_media_strategy.txt: Permission denied

# Post Challenge Tidy
# delete folders in tmp/data
cd /tmp/data
ls
# IT  Marketing  Sales
rm -r IT
rm -r Marketing
rm -r Sales
ls
# No folders/files remain

# remove users and groups
userdel -r -f james
userdel -r -f destiny
userdel -r -f carolyn

groupdel marketing-team
groupdel sales-team
groupdel it-team