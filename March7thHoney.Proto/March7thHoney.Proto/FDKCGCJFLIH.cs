using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FDKCGCJFLIH : IMessage<FDKCGCJFLIH>, IMessage, IEquatable<FDKCGCJFLIH>, IDeepCloneable<FDKCGCJFLIH>, IBufferMessage
{
	private static readonly MessageParser<FDKCGCJFLIH> _parser = new MessageParser<FDKCGCJFLIH>(() => new FDKCGCJFLIH());

	private UnknownFieldSet _unknownFields;

	public const int OGKNEBGDEFNFieldNumber = 11;

	private uint oGKNEBGDEFN_;

	public const int ODDFEAEEJJDFieldNumber = 15;

	private uint oDDFEAEEJJD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FDKCGCJFLIH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FDKCGCJFLIHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public FDKCGCJFLIH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FDKCGCJFLIH(FDKCGCJFLIH other)
		: this()
	{
		oGKNEBGDEFN_ = other.oGKNEBGDEFN_;
		oDDFEAEEJJD_ = other.oDDFEAEEJJD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FDKCGCJFLIH Clone()
	{
		return new FDKCGCJFLIH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FDKCGCJFLIH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FDKCGCJFLIH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OGKNEBGDEFN != other.OGKNEBGDEFN)
		{
			return false;
		}
		if (ODDFEAEEJJD != other.ODDFEAEEJJD)
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
		if (OGKNEBGDEFN != 0)
		{
			num ^= OGKNEBGDEFN.GetHashCode();
		}
		if (ODDFEAEEJJD != 0)
		{
			num ^= ODDFEAEEJJD.GetHashCode();
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
		if (OGKNEBGDEFN != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(OGKNEBGDEFN);
		}
		if (ODDFEAEEJJD != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(ODDFEAEEJJD);
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
		if (OGKNEBGDEFN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OGKNEBGDEFN);
		}
		if (ODDFEAEEJJD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ODDFEAEEJJD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FDKCGCJFLIH other)
	{
		if (other != null)
		{
			if (other.OGKNEBGDEFN != 0)
			{
				OGKNEBGDEFN = other.OGKNEBGDEFN;
			}
			if (other.ODDFEAEEJJD != 0)
			{
				ODDFEAEEJJD = other.ODDFEAEEJJD;
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
			case 88u:
				OGKNEBGDEFN = input.ReadUInt32();
				break;
			case 120u:
				ODDFEAEEJJD = input.ReadUInt32();
				break;
			}
		}
	}
}
