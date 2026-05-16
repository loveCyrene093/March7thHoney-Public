using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FECCGGMMBMK : IMessage<FECCGGMMBMK>, IMessage, IEquatable<FECCGGMMBMK>, IDeepCloneable<FECCGGMMBMK>, IBufferMessage
{
	private static readonly MessageParser<FECCGGMMBMK> _parser = new MessageParser<FECCGGMMBMK>(() => new FECCGGMMBMK());

	private UnknownFieldSet _unknownFields;

	public const int LLKOFNDAKHGFieldNumber = 1;

	private uint lLKOFNDAKHG_;

	public const int RetcodeFieldNumber = 2;

	private uint retcode_;

	public const int CDKEDFPEFIJFieldNumber = 12;

	private uint cDKEDFPEFIJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FECCGGMMBMK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FECCGGMMBMKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public FECCGGMMBMK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FECCGGMMBMK(FECCGGMMBMK other)
		: this()
	{
		lLKOFNDAKHG_ = other.lLKOFNDAKHG_;
		retcode_ = other.retcode_;
		cDKEDFPEFIJ_ = other.cDKEDFPEFIJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FECCGGMMBMK Clone()
	{
		return new FECCGGMMBMK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FECCGGMMBMK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FECCGGMMBMK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LLKOFNDAKHG != other.LLKOFNDAKHG)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (CDKEDFPEFIJ != other.CDKEDFPEFIJ)
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
		if (LLKOFNDAKHG != 0)
		{
			num ^= LLKOFNDAKHG.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (CDKEDFPEFIJ != 0)
		{
			num ^= CDKEDFPEFIJ.GetHashCode();
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
		if (LLKOFNDAKHG != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(LLKOFNDAKHG);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Retcode);
		}
		if (CDKEDFPEFIJ != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(CDKEDFPEFIJ);
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
		if (LLKOFNDAKHG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LLKOFNDAKHG);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (CDKEDFPEFIJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CDKEDFPEFIJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FECCGGMMBMK other)
	{
		if (other != null)
		{
			if (other.LLKOFNDAKHG != 0)
			{
				LLKOFNDAKHG = other.LLKOFNDAKHG;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.CDKEDFPEFIJ != 0)
			{
				CDKEDFPEFIJ = other.CDKEDFPEFIJ;
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
				LLKOFNDAKHG = input.ReadUInt32();
				break;
			case 16u:
				Retcode = input.ReadUInt32();
				break;
			case 96u:
				CDKEDFPEFIJ = input.ReadUInt32();
				break;
			}
		}
	}
}
