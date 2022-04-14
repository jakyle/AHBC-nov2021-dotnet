export interface ProfileData { 
	id: number;
	name: string;
	description: string;
	profilePic: string;
}


export const profiles: ProfileData[] = [ 
	{
		id: 1,
		name: "James Jackson",
		description: "Full-stack developer",
		profilePic: "https://avatars.githubusercontent.com/u/13954886?s=400&v=4"
	},
	{
		id: 2,
		name: "John Doe, Jr.",
		description: "NObody knows...",
		profilePic: "https://yt3.ggpht.com/a/AATXAJwrjuh6IEdCqDz7lvdHgYGDVlQOv2urgow9_NXh=s900-c-k-c0xffffffff-no-rj-mo"
	}
]