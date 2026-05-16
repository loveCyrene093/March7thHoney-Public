using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetPlayerInfoCsReq : IMessage<SetPlayerInfoCsReq>, IMessage, IEquatable<SetPlayerInfoCsReq>, IDeepCloneable<SetPlayerInfoCsReq>, IBufferMessage
{
	private static readonly MessageParser<SetPlayerInfoCsReq> _parser = new MessageParser<SetPlayerInfoCsReq>(() => new SetPlayerInfoCsReq());

	private UnknownFieldSet _unknownFields;

	public const int GenderFieldNumber = 2;

	private Gender gender_;

	public const int NicknameFieldNumber = 10;

	private string nickname_ = "";

	public const int IsModifyFieldNumber = 15;

	private bool isModify_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetPlayerInfoCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SetPlayerInfoCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Gender Gender
	{
		get
		{
			return gender_;
		}
		set
		{
			gender_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Nickname
	{
		get
		{
			return nickname_;
		}
		set
		{
			nickname_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

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
	public SetPlayerInfoCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetPlayerInfoCsReq(SetPlayerInfoCsReq other)
		: this()
	{
		gender_ = other.gender_;
		nickname_ = other.nickname_;
		isModify_ = other.isModify_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetPlayerInfoCsReq Clone()
	{
		return new SetPlayerInfoCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SetPlayerInfoCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetPlayerInfoCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Gender != other.Gender)
		{
			return false;
		}
		if (Nickname != other.Nickname)
		{
			return false;
		}
		if (IsModify != other.IsModify)
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
		if (Gender != Gender.None)
		{
			num ^= Gender.GetHashCode();
		}
		if (Nickname.Length != 0)
		{
			num ^= Nickname.GetHashCode();
		}
		if (IsModify)
		{
			num ^= IsModify.GetHashCode();
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
		if (Gender != Gender.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Gender);
		}
		if (Nickname.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(Nickname);
		}
		if (IsModify)
		{
			output.WriteRawTag(120);
			output.WriteBool(IsModify);
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
		if (Gender != Gender.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Gender);
		}
		if (Nickname.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Nickname);
		}
		if (IsModify)
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
	public void MergeFrom(SetPlayerInfoCsReq other)
	{
		if (other != null)
		{
			if (other.Gender != Gender.None)
			{
				Gender = other.Gender;
			}
			if (other.Nickname.Length != 0)
			{
				Nickname = other.Nickname;
			}
			if (other.IsModify)
			{
				IsModify = other.IsModify;
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
			case 16u:
				Gender = (Gender)input.ReadEnum();
				break;
			case 82u:
				Nickname = input.ReadString();
				break;
			case 120u:
				IsModify = input.ReadBool();
				break;
			}
		}
	}
}
