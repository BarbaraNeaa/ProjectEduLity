-- Drop the existing function if it exists
DROP FUNCTION IF EXISTS u_login(character varying, character varying);

-- Drop the existing table if it exists
DROP TABLE IF EXISTS tbl_users;

-- Create table contains data
CREATE TABLE tbl_users
(
    username CHARACTER VARYING(150) NOT NULL PRIMARY KEY,
    password CHARACTER VARYING(150)
);

-- Insert some demo records
INSERT INTO tbl_users VALUES('admin', 'admin');
INSERT INTO tbl_users VALUES('user', '123');
INSERT INTO tbl_users VALUES('Barbara Nea', '2304');

-- Select all records from tbl_users
SELECT * FROM tbl_users;

-- Create function login
CREATE OR REPLACE FUNCTION u_login(_username CHARACTER VARYING, _password CHARACTER VARYING)
RETURNS INT AS
$$
BEGIN
    RETURN EXISTS (SELECT 1 FROM tbl_users WHERE username = _username AND password = _password)::INT;
END
$$
LANGUAGE plpgsql;

-- Create function for user registration
CREATE OR REPLACE FUNCTION u_register(_username CHARACTER VARYING, _password CHARACTER VARYING)
RETURNS VOID AS
$$
BEGIN
    -- Check if the username already exists
    IF NOT EXISTS (SELECT 1 FROM tbl_users WHERE username = _username) THEN
        -- If username is available, insert the new user
        INSERT INTO tbl_users(username, password) VALUES (_username, _password);
    END IF;
END
$$
LANGUAGE plpgsql;

-- Test functions
SELECT u_login('Barbara Nea', '2304');
SELECT u_register('newuser', 'newpassword');
