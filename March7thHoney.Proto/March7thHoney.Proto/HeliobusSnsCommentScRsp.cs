using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HeliobusSnsCommentScRsp : IMessage<HeliobusSnsCommentScRsp>, IMessage, IEquatable<HeliobusSnsCommentScRsp>, IDeepCloneable<HeliobusSnsCommentScRsp>, IBufferMessage
{
	private static readonly MessageParser<HeliobusSnsCommentScRsp> _parser = new MessageParser<HeliobusSnsCommentScRsp>(() => new HeliobusSnsCommentScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	public const int IGIPAKELJFDFieldNumber = 14;

	private DLFOGJGCCGP iGIPAKELJFD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HeliobusSnsCommentScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HeliobusSnsCommentScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public DLFOGJGCCGP IGIPAKELJFD
	{
		get
		{
			return iGIPAKELJFD_;
		}
		set
		{
			iGIPAKELJFD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusSnsCommentScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusSnsCommentScRsp(HeliobusSnsCommentScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		iGIPAKELJFD_ = ((other.iGIPAKELJFD_ != null) ? other.iGIPAKELJFD_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusSnsCommentScRsp Clone()
	{
		return new HeliobusSnsCommentScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HeliobusSnsCommentScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HeliobusSnsCommentScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(IGIPAKELJFD, other.IGIPAKELJFD))
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (iGIPAKELJFD_ != null)
		{
			num ^= IGIPAKELJFD.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Retcode);
		}
		if (iGIPAKELJFD_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(IGIPAKELJFD);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (iGIPAKELJFD_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IGIPAKELJFD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HeliobusSnsCommentScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.iGIPAKELJFD_ != null)
		{
			if (iGIPAKELJFD_ == null)
			{
				IGIPAKELJFD = new DLFOGJGCCGP();
			}
			IGIPAKELJFD.MergeFrom(other.IGIPAKELJFD);
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
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			case 114u:
				if (iGIPAKELJFD_ == null)
				{
					IGIPAKELJFD = new DLFOGJGCCGP();
				}
				input.ReadMessage(IGIPAKELJFD);
				break;
			}
		}
	}
}
