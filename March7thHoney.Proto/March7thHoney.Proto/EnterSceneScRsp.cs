using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EnterSceneScRsp : IMessage<EnterSceneScRsp>, IMessage, IEquatable<EnterSceneScRsp>, IDeepCloneable<EnterSceneScRsp>, IBufferMessage
{
	private static readonly MessageParser<EnterSceneScRsp> _parser = new MessageParser<EnterSceneScRsp>(() => new EnterSceneScRsp());

	private UnknownFieldSet _unknownFields;

	public const int SceneIdentifierFieldNumber = 2;

	private SceneIdentifier sceneIdentifier_;

	public const int RetcodeFieldNumber = 10;

	private uint retcode_;

	public const int IsCloseMapFieldNumber = 13;

	private bool isCloseMap_;

	public const int IsOverMapFieldNumber = 14;

	private bool isOverMap_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EnterSceneScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EnterSceneScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneIdentifier SceneIdentifier
	{
		get
		{
			return sceneIdentifier_;
		}
		set
		{
			sceneIdentifier_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsCloseMap
	{
		get
		{
			return isCloseMap_;
		}
		set
		{
			isCloseMap_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsOverMap
	{
		get
		{
			return isOverMap_;
		}
		set
		{
			isOverMap_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterSceneScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterSceneScRsp(EnterSceneScRsp other)
		: this()
	{
		sceneIdentifier_ = ((other.sceneIdentifier_ != null) ? other.sceneIdentifier_.Clone() : null);
		retcode_ = other.retcode_;
		isCloseMap_ = other.isCloseMap_;
		isOverMap_ = other.isOverMap_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterSceneScRsp Clone()
	{
		return new EnterSceneScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EnterSceneScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EnterSceneScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(SceneIdentifier, other.SceneIdentifier))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (IsCloseMap != other.IsCloseMap)
		{
			return false;
		}
		if (IsOverMap != other.IsOverMap)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (sceneIdentifier_ != null)
		{
			num ^= SceneIdentifier.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (IsCloseMap)
		{
			num ^= IsCloseMap.GetHashCode();
		}
		if (IsOverMap)
		{
			num ^= IsOverMap.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (sceneIdentifier_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(SceneIdentifier);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Retcode);
		}
		if (IsCloseMap)
		{
			output.WriteRawTag(104);
			output.WriteBool(IsCloseMap);
		}
		if (IsOverMap)
		{
			output.WriteRawTag(112);
			output.WriteBool(IsOverMap);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (sceneIdentifier_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SceneIdentifier);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (IsCloseMap)
		{
			num += 2;
		}
		if (IsOverMap)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EnterSceneScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.sceneIdentifier_ != null)
		{
			if (sceneIdentifier_ == null)
			{
				SceneIdentifier = new SceneIdentifier();
			}
			SceneIdentifier.MergeFrom(other.SceneIdentifier);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.IsCloseMap)
		{
			IsCloseMap = other.IsCloseMap;
		}
		if (other.IsOverMap)
		{
			IsOverMap = other.IsOverMap;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 18u:
				if (sceneIdentifier_ == null)
				{
					SceneIdentifier = new SceneIdentifier();
				}
				input.ReadMessage(SceneIdentifier);
				break;
			case 80u:
				Retcode = input.ReadUInt32();
				break;
			case 104u:
				IsCloseMap = input.ReadBool();
				break;
			case 112u:
				IsOverMap = input.ReadBool();
				break;
			}
		}
	}
}
