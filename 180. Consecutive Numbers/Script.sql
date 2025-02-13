SELECT DISTINCT
	T.NUM as ConsecutiveNums 
FROM
	(
		SELECT
			E.NUM,
			(
				SELECT
					E0.NUM
				FROM
					PUBLIC.LOGS E0
				WHERE
					E0.ID = E.ID -1
			) AS PREV_NUM,
			(
				SELECT
					E0.NUM
				FROM
					PUBLIC.LOGS E0
				WHERE
					E0.ID = E.ID + 1
			) AS NEXT_NUM
		FROM
			PUBLIC.LOGS E
		ORDER BY
			E.ID
	) T
WHERE
	T.PREV_NUM = T.NUM
	AND T.NUM = T.NEXT_NUM