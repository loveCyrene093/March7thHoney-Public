using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NJCOFDJNMML : IMessage<NJCOFDJNMML>, IMessage, IEquatable<NJCOFDJNMML>, IDeepCloneable<NJCOFDJNMML>, IBufferMessage
{
	private static readonly MessageParser<NJCOFDJNMML> _parser = new MessageParser<NJCOFDJNMML>(() => new NJCOFDJNMML());

	private UnknownFieldSet _unknownFields;

	public const int POOEFNDPEILFieldNumber = 1;

	private uint pOOEFNDPEIL_;

	public const int NFGJIDADLEDFieldNumber = 2;

	private uint nFGJIDADLED_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NJCOFDJNMML> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NJCOFDJNMMLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint POOEFNDPEIL
	{
		get
		{
			return pOOEFNDPEIL_;
		}
		set
		{
			pOOEFNDPEIL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NFGJIDADLED
	{
		get
		{
			return nFGJIDADLED_;
		}
		set
		{
			nFGJIDADLED_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NJCOFDJNMML()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NJCOFDJNMML(NJCOFDJNMML other)
		: this()
	{
		pOOEFNDPEIL_ = other.pOOEFNDPEIL_;
		nFGJIDADLED_ = other.nFGJIDADLED_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NJCOFDJNMML Clone()
	{
		return new NJCOFDJNMML(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NJCOFDJNMML);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NJCOFDJNMML other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (POOEFNDPEIL != other.POOEFNDPEIL)
		{
			return false;
		}
		if (NFGJIDADLED != other.NFGJIDADLED)
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
		if (POOEFNDPEIL != 0)
		{
			num ^= POOEFNDPEIL.GetHashCode();
		}
		if (NFGJIDADLED != 0)
		{
			num ^= NFGJIDADLED.GetHashCode();
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
		if (POOEFNDPEIL != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(POOEFNDPEIL);
		}
		if (NFGJIDADLED != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(NFGJIDADLED);
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
		if (POOEFNDPEIL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(POOEFNDPEIL);
		}
		if (NFGJIDADLED != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NFGJIDADLED);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NJCOFDJNMML other)
	{
		if (other != null)
		{
			if (other.POOEFNDPEIL != 0)
			{
				POOEFNDPEIL = other.POOEFNDPEIL;
			}
			if (other.NFGJIDADLED != 0)
			{
				NFGJIDADLED = other.NFGJIDADLED;
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
				POOEFNDPEIL = input.ReadUInt32();
				break;
			case 16u:
				NFGJIDADLED = input.ReadUInt32();
				break;
			}
		}
	}
}
