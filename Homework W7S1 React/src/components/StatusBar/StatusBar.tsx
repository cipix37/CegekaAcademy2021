import React from 'react'
import {Grid,GridColumn,Segment} from 'semantic-ui-react'

interface StatusBarProps{
    title:string;
}

const StatusBar: React.FC<StatusBarProps> = ({title, children}) => {
    return(
        <Grid columns={2} className='status-bar'>
            <GridColumn>
                <Segment basic>
                    {title}
                </Segment>
            </GridColumn>
            <GridColumn textAlign='right'>
                <Segment basic>
                    {children}
                </Segment>
            </GridColumn>
        </Grid>
    );
}

export default StatusBar;