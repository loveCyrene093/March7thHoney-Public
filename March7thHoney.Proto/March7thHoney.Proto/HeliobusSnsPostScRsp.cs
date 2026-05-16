using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HeliobusSnsPostScRsp : IMessage<HeliobusSnsPostScRsp>, IMessage, IEquatable<HeliobusSnsPostScRsp>, IDeepCloneable<HeliobusSnsPostScRsp>, IBufferMessage
{
	private static readonly MessageParser<HeliobusSnsPostScRsp> _parser = new MessageParser<HeliobusSnsPostScRsp>(() => new HeliobusSnsPostScRsp());

	private UnknownFieldSet _unknownFields;

	public const int IGIPAKELJFDFieldNumber = 11;

	private DLFOGJGCCGP iGIPAKELJFD_;

	public const int RetcodeFieldNumber = 12;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HeliobusSnsPostScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HeliobusSnsPostScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public HeliobusSnsPostScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusSnsPostScRsp(HeliobusSnsPostScRsp other)
		: this()
	{
		iGIPAKELJFD_ = ((other.iGIPAKELJFD_ != null) ? other.iGIPAKELJFD_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusSnsPostScRsp Clone()
	{
		return new HeliobusSnsPostScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HeliobusSnsPostScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HeliobusSnsPostScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(IGIPAKELJFD, other.IGIPAKELJFD))
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
		if (iGIPAKELJFD_ != null)
		{
			num ^= IGIPAKELJFD.GetHashCode();
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
		if (iGIPAKELJFD_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(IGIPAKELJFD);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(96);
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
		if (iGIPAKELJFD_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IGIPAKELJFD);
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
	public void MergeFrom(HeliobusSnsPostScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.iGIPAKELJFD_ != null)
		{
			if (iGIPAKELJFD_ == null)
			{
				IGIPAKELJFD = new DLFOGJGCCGP();
			}
			IGIPAKELJFD.MergeFrom(other.IGIPAKELJFD);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
			case 90u:
				if (iGIPAKELJFD_ == null)
				{
					IGIPAKELJFD = new DLFOGJGCCGP();
				}
				input.ReadMessage(IGIPAKELJFD);
				break;
			case 96u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
