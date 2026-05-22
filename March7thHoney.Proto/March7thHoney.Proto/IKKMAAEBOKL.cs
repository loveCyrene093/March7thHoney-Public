using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IKKMAAEBOKL : IMessage<IKKMAAEBOKL>, IMessage, IEquatable<IKKMAAEBOKL>, IDeepCloneable<IKKMAAEBOKL>, IBufferMessage
{
	private static readonly MessageParser<IKKMAAEBOKL> _parser = new MessageParser<IKKMAAEBOKL>(() => new IKKMAAEBOKL());

	private UnknownFieldSet _unknownFields;

	public const int ProgressFieldNumber = 5;

	private uint progress_;

	public const int ICFPPOLJDPPFieldNumber = 11;

	private uint iCFPPOLJDPP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IKKMAAEBOKL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IKKMAAEBOKLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Progress
	{
		get
		{
			return progress_;
		}
		set
		{
			progress_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ICFPPOLJDPP
	{
		get
		{
			return iCFPPOLJDPP_;
		}
		set
		{
			iCFPPOLJDPP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IKKMAAEBOKL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IKKMAAEBOKL(IKKMAAEBOKL other)
		: this()
	{
		progress_ = other.progress_;
		iCFPPOLJDPP_ = other.iCFPPOLJDPP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IKKMAAEBOKL Clone()
	{
		return new IKKMAAEBOKL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IKKMAAEBOKL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IKKMAAEBOKL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Progress != other.Progress)
		{
			return false;
		}
		if (ICFPPOLJDPP != other.ICFPPOLJDPP)
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
		if (Progress != 0)
		{
			num ^= Progress.GetHashCode();
		}
		if (ICFPPOLJDPP != 0)
		{
			num ^= ICFPPOLJDPP.GetHashCode();
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
		if (Progress != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Progress);
		}
		if (ICFPPOLJDPP != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(ICFPPOLJDPP);
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
		if (Progress != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Progress);
		}
		if (ICFPPOLJDPP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ICFPPOLJDPP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IKKMAAEBOKL other)
	{
		if (other != null)
		{
			if (other.Progress != 0)
			{
				Progress = other.Progress;
			}
			if (other.ICFPPOLJDPP != 0)
			{
				ICFPPOLJDPP = other.ICFPPOLJDPP;
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
			case 40u:
				Progress = input.ReadUInt32();
				break;
			case 88u:
				ICFPPOLJDPP = input.ReadUInt32();
				break;
			}
		}
	}
}
