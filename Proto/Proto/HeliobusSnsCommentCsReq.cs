using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HeliobusSnsCommentCsReq : IMessage<HeliobusSnsCommentCsReq>, IMessage, IEquatable<HeliobusSnsCommentCsReq>, IDeepCloneable<HeliobusSnsCommentCsReq>, IBufferMessage
{
	private static readonly MessageParser<HeliobusSnsCommentCsReq> _parser = new MessageParser<HeliobusSnsCommentCsReq>(() => new HeliobusSnsCommentCsReq());

	private UnknownFieldSet _unknownFields;

	public const int HADOJCLDHNGFieldNumber = 8;

	private uint hADOJCLDHNG_;

	public const int CDKEDFPEFIJFieldNumber = 10;

	private uint cDKEDFPEFIJ_;

	public const int LLKOFNDAKHGFieldNumber = 14;

	private uint lLKOFNDAKHG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HeliobusSnsCommentCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HeliobusSnsCommentCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HADOJCLDHNG
	{
		get
		{
			return hADOJCLDHNG_;
		}
		set
		{
			hADOJCLDHNG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CDKEDFPEFIJ
	{
		get
		{
			return cDKEDFPEFIJ_;
		}
		set
		{
			cDKEDFPEFIJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LLKOFNDAKHG
	{
		get
		{
			return lLKOFNDAKHG_;
		}
		set
		{
			lLKOFNDAKHG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusSnsCommentCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusSnsCommentCsReq(HeliobusSnsCommentCsReq other)
		: this()
	{
		hADOJCLDHNG_ = other.hADOJCLDHNG_;
		cDKEDFPEFIJ_ = other.cDKEDFPEFIJ_;
		lLKOFNDAKHG_ = other.lLKOFNDAKHG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusSnsCommentCsReq Clone()
	{
		return new HeliobusSnsCommentCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HeliobusSnsCommentCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HeliobusSnsCommentCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HADOJCLDHNG != other.HADOJCLDHNG)
		{
			return false;
		}
		if (CDKEDFPEFIJ != other.CDKEDFPEFIJ)
		{
			return false;
		}
		if (LLKOFNDAKHG != other.LLKOFNDAKHG)
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
		if (HADOJCLDHNG != 0)
		{
			num ^= HADOJCLDHNG.GetHashCode();
		}
		if (CDKEDFPEFIJ != 0)
		{
			num ^= CDKEDFPEFIJ.GetHashCode();
		}
		if (LLKOFNDAKHG != 0)
		{
			num ^= LLKOFNDAKHG.GetHashCode();
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
		if (HADOJCLDHNG != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(HADOJCLDHNG);
		}
		if (CDKEDFPEFIJ != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(CDKEDFPEFIJ);
		}
		if (LLKOFNDAKHG != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(LLKOFNDAKHG);
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
		if (HADOJCLDHNG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HADOJCLDHNG);
		}
		if (CDKEDFPEFIJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CDKEDFPEFIJ);
		}
		if (LLKOFNDAKHG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LLKOFNDAKHG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HeliobusSnsCommentCsReq other)
	{
		if (other != null)
		{
			if (other.HADOJCLDHNG != 0)
			{
				HADOJCLDHNG = other.HADOJCLDHNG;
			}
			if (other.CDKEDFPEFIJ != 0)
			{
				CDKEDFPEFIJ = other.CDKEDFPEFIJ;
			}
			if (other.LLKOFNDAKHG != 0)
			{
				LLKOFNDAKHG = other.LLKOFNDAKHG;
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
			case 64u:
				HADOJCLDHNG = input.ReadUInt32();
				break;
			case 80u:
				CDKEDFPEFIJ = input.ReadUInt32();
				break;
			case 112u:
				LLKOFNDAKHG = input.ReadUInt32();
				break;
			}
		}
	}
}
