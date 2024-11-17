/* Write your PL/SQL query statement below */
select a.player_id, to_char(min(a.event_date), 'YYYY-MM-DD') as first_login
from Activity a
group by a.player_id;