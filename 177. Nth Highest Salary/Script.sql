CREATE
OR REPLACE FUNCTION NTHHIGHESTSALARY (N INT) RETURNS TABLE (SALARY INT) AS $$
BEGIN
  RETURN QUERY (  
  
      SELECT
	TTL.SALARY
FROM
	(
		SELECT
			E.SALARY,
			ROW_NUMBER() OVER (
				ORDER BY
					E.SALARY DESC
			) AS NUM
		FROM
			PUBLIC.EMPLOYEE E
		GROUP BY
			E.SALARY
		ORDER BY
			1 DESC
	) TTL
WHERE
	TTL.NUM = N	
	
  );  
END;
$$ LANGUAGE PLPGSQL;