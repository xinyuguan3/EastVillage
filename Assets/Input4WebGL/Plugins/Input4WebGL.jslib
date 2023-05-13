var Input4WebGL = {
	$input:null,
	$unityGameObjectName : "",
	$Inputing: function()
	{
		if(unityGameObjectName!=null && input != null)
		{
			SendMessage(unityGameObjectName, "OnInputText",input.value);
		}
	},
	$InputEnd: function()
	{
		if(unityGameObjectName!=null && input != null)
		{
			SendMessage(unityGameObjectName,"OnInputEnd");
		}
	},
	InputShow: function(GameObjectName_,v_)
	{
		var GameObjectName = Pointer_stringify(GameObjectName_);
		var v = Pointer_stringify(v_);
		if(input==null){
			input = document.createElement("input");
			input.type = "text";
			input.id = "Input4WebGlId";
			input.name = "Input4WebGl";
			input.style = "visibility:hidden;";
			input.oninput = Inputing;
			input.onblur = InputEnd;
			document.body.appendChild(input);
		}
		input.value = v;
		unityGameObjectName = GameObjectName;
		input.style.visibility = "visible";  
		input.style.opacity = 0;
   		input.focus();
	}
};
autoAddDeps(Input4WebGL, '$input');
autoAddDeps(Input4WebGL, '$Inputing');
autoAddDeps(Input4WebGL, '$InputEnd');
autoAddDeps(Input4WebGL, '$unityGameObjectName');
mergeInto(LibraryManager.library, Input4WebGL);