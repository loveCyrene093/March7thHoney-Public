using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetPlayerInfoScRsp : IMessage<SetPlayerInfoScRsp>, IMessage, IEquatable<SetPlayerInfoScRsp>, IDeepCloneable<SetPlayerInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<SetPlayerInfoScRsp> _parser = new MessageParser<SetPlayerInfoScRsp>(() => new SetPlayerInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int IsModifyFieldNumber = 1;

	private bool isModify_;

	public const int SetTimeFieldNumber = 5;

	private long setTime_;

	public const int CurAvatarPathFieldNumber = 6;

	private MultiPathAvatarType curAvatarPath_;

	public const int RetcodeFieldNumber = 7;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetPlayerInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SetPlayerInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsModify
	{
		get
		{
			return isModify_;
		}
		set
		{
			isModify_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long SetTime
	{
		get
		{
			return setTime_;
		}
		set
		{
			setTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MultiPathAvatarType CurAvatarPath
	{
		get
		{
			return curAvatarPath_;
		}
		set
		{
			curAvatarPath_ = value;
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
	public SetPlayerInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetPlayerInfoScRsp(SetPlayerInfoScRsp other)
		: this()
	{
		isModify_ = other.isModify_;
		setTime_ = other.setTime_;
		curAvatarPath_ = other.curAvatarPath_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetPlayerInfoScRsp Clone()
	{
		return new SetPlayerInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SetPlayerInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetPlayerInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsModify != other.IsModify)
		{
			return false;
		}
		if (SetTime != other.SetTime)
		{
			return false;
		}
		if (CurAvatarPath != other.CurAvatarPath)
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (IsModify)
		{
			num ^= IsModify.GetHashCode();
		}
		if (SetTime != 0L)
		{
			num ^= SetTime.GetHashCode();
		}
		if (CurAvatarPath != MultiPathAvatarType.None)
		{
			num ^= CurAvatarPath.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (IsModify)
		{
			output.WriteRawTag(8);
			output.WriteBool(IsModify);
		}
		if (SetTime != 0L)
		{
			output.WriteRawTag(40);
			output.WriteInt64(SetTime);
		}
		if (CurAvatarPath != MultiPathAvatarType.None)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)CurAvatarPath);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Retcode);
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
		if (IsModify)
		{
			num += 2;
		}
		if (SetTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(SetTime);
		}
		if (CurAvatarPath != MultiPathAvatarType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CurAvatarPath);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SetPlayerInfoScRsp other)
	{
		if (other != null)
		{
			if (other.IsModify)
			{
				IsModify = other.IsModify;
			}
			if (other.SetTime != 0L)
			{
				SetTime = other.SetTime;
			}
			if (other.CurAvatarPath != MultiPathAvatarType.None)
			{
				CurAvatarPath = other.CurAvatarPath;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			case 8u:
				IsModify = input.ReadBool();
				break;
			case 40u:
				SetTime = input.ReadInt64();
				break;
			case 48u:
				CurAvatarPath = (MultiPathAvatarType)input.ReadEnum();
				break;
			case 56u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
