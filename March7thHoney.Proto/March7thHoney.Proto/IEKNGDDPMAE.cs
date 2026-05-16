using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IEKNGDDPMAE : IMessage<IEKNGDDPMAE>, IMessage, IEquatable<IEKNGDDPMAE>, IDeepCloneable<IEKNGDDPMAE>, IBufferMessage
{
	private static readonly MessageParser<IEKNGDDPMAE> _parser = new MessageParser<IEKNGDDPMAE>(() => new IEKNGDDPMAE());

	private UnknownFieldSet _unknownFields;

	public const int ODDFEAEEJJDFieldNumber = 6;

	private uint oDDFEAEEJJD_;

	public const int OGKNEBGDEFNFieldNumber = 7;

	private uint oGKNEBGDEFN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IEKNGDDPMAE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IEKNGDDPMAEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ODDFEAEEJJD
	{
		get
		{
			return oDDFEAEEJJD_;
		}
		set
		{
			oDDFEAEEJJD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OGKNEBGDEFN
	{
		get
		{
			return oGKNEBGDEFN_;
		}
		set
		{
			oGKNEBGDEFN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IEKNGDDPMAE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IEKNGDDPMAE(IEKNGDDPMAE other)
		: this()
	{
		oDDFEAEEJJD_ = other.oDDFEAEEJJD_;
		oGKNEBGDEFN_ = other.oGKNEBGDEFN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IEKNGDDPMAE Clone()
	{
		return new IEKNGDDPMAE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IEKNGDDPMAE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IEKNGDDPMAE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ODDFEAEEJJD != other.ODDFEAEEJJD)
		{
			return false;
		}
		if (OGKNEBGDEFN != other.OGKNEBGDEFN)
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
		if (ODDFEAEEJJD != 0)
		{
			num ^= ODDFEAEEJJD.GetHashCode();
		}
		if (OGKNEBGDEFN != 0)
		{
			num ^= OGKNEBGDEFN.GetHashCode();
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
		if (ODDFEAEEJJD != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(ODDFEAEEJJD);
		}
		if (OGKNEBGDEFN != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(OGKNEBGDEFN);
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
		if (ODDFEAEEJJD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ODDFEAEEJJD);
		}
		if (OGKNEBGDEFN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OGKNEBGDEFN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IEKNGDDPMAE other)
	{
		if (other != null)
		{
			if (other.ODDFEAEEJJD != 0)
			{
				ODDFEAEEJJD = other.ODDFEAEEJJD;
			}
			if (other.OGKNEBGDEFN != 0)
			{
				OGKNEBGDEFN = other.OGKNEBGDEFN;
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
			case 48u:
				ODDFEAEEJJD = input.ReadUInt32();
				break;
			case 56u:
				OGKNEBGDEFN = input.ReadUInt32();
				break;
			}
		}
	}
}
