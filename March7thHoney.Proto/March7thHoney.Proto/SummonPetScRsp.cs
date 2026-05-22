using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SummonPetScRsp : IMessage<SummonPetScRsp>, IMessage, IEquatable<SummonPetScRsp>, IDeepCloneable<SummonPetScRsp>, IBufferMessage
{
	private static readonly MessageParser<SummonPetScRsp> _parser = new MessageParser<SummonPetScRsp>(() => new SummonPetScRsp());

	private UnknownFieldSet _unknownFields;

	public const int SelectPetIdFieldNumber = 13;

	private uint selectPetId_;

	public const int RetcodeFieldNumber = 14;

	private uint retcode_;

	public const int CurPetIdFieldNumber = 15;

	private uint curPetId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SummonPetScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SummonPetScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SelectPetId
	{
		get
		{
			return selectPetId_;
		}
		set
		{
			selectPetId_ = value;
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
	public uint CurPetId
	{
		get
		{
			return curPetId_;
		}
		set
		{
			curPetId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SummonPetScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SummonPetScRsp(SummonPetScRsp other)
		: this()
	{
		selectPetId_ = other.selectPetId_;
		retcode_ = other.retcode_;
		curPetId_ = other.curPetId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SummonPetScRsp Clone()
	{
		return new SummonPetScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SummonPetScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SummonPetScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SelectPetId != other.SelectPetId)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (CurPetId != other.CurPetId)
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
		if (SelectPetId != 0)
		{
			num ^= SelectPetId.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (CurPetId != 0)
		{
			num ^= CurPetId.GetHashCode();
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
		if (SelectPetId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(SelectPetId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(Retcode);
		}
		if (CurPetId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(CurPetId);
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
		if (SelectPetId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SelectPetId);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (CurPetId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurPetId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SummonPetScRsp other)
	{
		if (other != null)
		{
			if (other.SelectPetId != 0)
			{
				SelectPetId = other.SelectPetId;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.CurPetId != 0)
			{
				CurPetId = other.CurPetId;
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
			case 104u:
				SelectPetId = input.ReadUInt32();
				break;
			case 112u:
				Retcode = input.ReadUInt32();
				break;
			case 120u:
				CurPetId = input.ReadUInt32();
				break;
			}
		}
	}
}
