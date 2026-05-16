using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SelectChatBubbleScRsp : IMessage<SelectChatBubbleScRsp>, IMessage, IEquatable<SelectChatBubbleScRsp>, IDeepCloneable<SelectChatBubbleScRsp>, IBufferMessage
{
	private static readonly MessageParser<SelectChatBubbleScRsp> _parser = new MessageParser<SelectChatBubbleScRsp>(() => new SelectChatBubbleScRsp());

	private UnknownFieldSet _unknownFields;

	public const int DKJAGFKPFONFieldNumber = 3;

	private uint dKJAGFKPFON_;

	public const int RetcodeFieldNumber = 14;

	private uint retcode_;

	public const int CurChatBubbleFieldNumber = 15;

	private uint curChatBubble_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SelectChatBubbleScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SelectChatBubbleScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DKJAGFKPFON
	{
		get
		{
			return dKJAGFKPFON_;
		}
		set
		{
			dKJAGFKPFON_ = value;
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
	public uint CurChatBubble
	{
		get
		{
			return curChatBubble_;
		}
		set
		{
			curChatBubble_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SelectChatBubbleScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SelectChatBubbleScRsp(SelectChatBubbleScRsp other)
		: this()
	{
		dKJAGFKPFON_ = other.dKJAGFKPFON_;
		retcode_ = other.retcode_;
		curChatBubble_ = other.curChatBubble_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SelectChatBubbleScRsp Clone()
	{
		return new SelectChatBubbleScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SelectChatBubbleScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SelectChatBubbleScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DKJAGFKPFON != other.DKJAGFKPFON)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (CurChatBubble != other.CurChatBubble)
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
		if (DKJAGFKPFON != 0)
		{
			num ^= DKJAGFKPFON.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (CurChatBubble != 0)
		{
			num ^= CurChatBubble.GetHashCode();
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
		if (DKJAGFKPFON != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(DKJAGFKPFON);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(Retcode);
		}
		if (CurChatBubble != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(CurChatBubble);
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
		if (DKJAGFKPFON != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DKJAGFKPFON);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (CurChatBubble != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurChatBubble);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SelectChatBubbleScRsp other)
	{
		if (other != null)
		{
			if (other.DKJAGFKPFON != 0)
			{
				DKJAGFKPFON = other.DKJAGFKPFON;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.CurChatBubble != 0)
			{
				CurChatBubble = other.CurChatBubble;
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
			case 24u:
				DKJAGFKPFON = input.ReadUInt32();
				break;
			case 112u:
				Retcode = input.ReadUInt32();
				break;
			case 120u:
				CurChatBubble = input.ReadUInt32();
				break;
			}
		}
	}
}
