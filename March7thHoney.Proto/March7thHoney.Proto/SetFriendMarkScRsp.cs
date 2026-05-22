using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetFriendMarkScRsp : IMessage<SetFriendMarkScRsp>, IMessage, IEquatable<SetFriendMarkScRsp>, IDeepCloneable<SetFriendMarkScRsp>, IBufferMessage
{
	private static readonly MessageParser<SetFriendMarkScRsp> _parser = new MessageParser<SetFriendMarkScRsp>(() => new SetFriendMarkScRsp());

	private UnknownFieldSet _unknownFields;

	public const int UidFieldNumber = 4;

	private uint uid_;

	public const int RetcodeFieldNumber = 5;

	private uint retcode_;

	public const int KBNKNAHGPHGFieldNumber = 8;

	private bool kBNKNAHGPHG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetFriendMarkScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SetFriendMarkScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Uid
	{
		get
		{
			return uid_;
		}
		set
		{
			uid_ = value;
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
	public bool KBNKNAHGPHG
	{
		get
		{
			return kBNKNAHGPHG_;
		}
		set
		{
			kBNKNAHGPHG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetFriendMarkScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetFriendMarkScRsp(SetFriendMarkScRsp other)
		: this()
	{
		uid_ = other.uid_;
		retcode_ = other.retcode_;
		kBNKNAHGPHG_ = other.kBNKNAHGPHG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetFriendMarkScRsp Clone()
	{
		return new SetFriendMarkScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SetFriendMarkScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetFriendMarkScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Uid != other.Uid)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (KBNKNAHGPHG != other.KBNKNAHGPHG)
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
		if (Uid != 0)
		{
			num ^= Uid.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (KBNKNAHGPHG)
		{
			num ^= KBNKNAHGPHG.GetHashCode();
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
		if (Uid != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Uid);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Retcode);
		}
		if (KBNKNAHGPHG)
		{
			output.WriteRawTag(64);
			output.WriteBool(KBNKNAHGPHG);
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
		if (Uid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Uid);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (KBNKNAHGPHG)
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
	public void MergeFrom(SetFriendMarkScRsp other)
	{
		if (other != null)
		{
			if (other.Uid != 0)
			{
				Uid = other.Uid;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.KBNKNAHGPHG)
			{
				KBNKNAHGPHG = other.KBNKNAHGPHG;
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
			case 32u:
				Uid = input.ReadUInt32();
				break;
			case 40u:
				Retcode = input.ReadUInt32();
				break;
			case 64u:
				KBNKNAHGPHG = input.ReadBool();
				break;
			}
		}
	}
}
