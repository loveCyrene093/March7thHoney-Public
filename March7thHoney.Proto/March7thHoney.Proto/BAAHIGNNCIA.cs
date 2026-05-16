using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BAAHIGNNCIA : IMessage<BAAHIGNNCIA>, IMessage, IEquatable<BAAHIGNNCIA>, IDeepCloneable<BAAHIGNNCIA>, IBufferMessage
{
	private static readonly MessageParser<BAAHIGNNCIA> _parser = new MessageParser<BAAHIGNNCIA>(() => new BAAHIGNNCIA());

	private UnknownFieldSet _unknownFields;

	public const int FPKMKJEFLDEFieldNumber = 1;

	private uint fPKMKJEFLDE_;

	public const int HADGAPLBEMOFieldNumber = 2;

	private double hADGAPLBEMO_;

	public const int CGOABGKCBEFFieldNumber = 11;

	private uint cGOABGKCBEF_;

	public const int ENHOIMLIBJNFieldNumber = 12;

	private uint eNHOIMLIBJN_;

	public const int MEGCAGNHMIEFieldNumber = 13;

	private uint mEGCAGNHMIE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BAAHIGNNCIA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BAAHIGNNCIAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FPKMKJEFLDE
	{
		get
		{
			return fPKMKJEFLDE_;
		}
		set
		{
			fPKMKJEFLDE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double HADGAPLBEMO
	{
		get
		{
			return hADGAPLBEMO_;
		}
		set
		{
			hADGAPLBEMO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CGOABGKCBEF
	{
		get
		{
			return cGOABGKCBEF_;
		}
		set
		{
			cGOABGKCBEF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ENHOIMLIBJN
	{
		get
		{
			return eNHOIMLIBJN_;
		}
		set
		{
			eNHOIMLIBJN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MEGCAGNHMIE
	{
		get
		{
			return mEGCAGNHMIE_;
		}
		set
		{
			mEGCAGNHMIE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BAAHIGNNCIA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BAAHIGNNCIA(BAAHIGNNCIA other)
		: this()
	{
		fPKMKJEFLDE_ = other.fPKMKJEFLDE_;
		hADGAPLBEMO_ = other.hADGAPLBEMO_;
		cGOABGKCBEF_ = other.cGOABGKCBEF_;
		eNHOIMLIBJN_ = other.eNHOIMLIBJN_;
		mEGCAGNHMIE_ = other.mEGCAGNHMIE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BAAHIGNNCIA Clone()
	{
		return new BAAHIGNNCIA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BAAHIGNNCIA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BAAHIGNNCIA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FPKMKJEFLDE != other.FPKMKJEFLDE)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(HADGAPLBEMO, other.HADGAPLBEMO))
		{
			return false;
		}
		if (CGOABGKCBEF != other.CGOABGKCBEF)
		{
			return false;
		}
		if (ENHOIMLIBJN != other.ENHOIMLIBJN)
		{
			return false;
		}
		if (MEGCAGNHMIE != other.MEGCAGNHMIE)
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
		if (FPKMKJEFLDE != 0)
		{
			num ^= FPKMKJEFLDE.GetHashCode();
		}
		if (HADGAPLBEMO != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(HADGAPLBEMO);
		}
		if (CGOABGKCBEF != 0)
		{
			num ^= CGOABGKCBEF.GetHashCode();
		}
		if (ENHOIMLIBJN != 0)
		{
			num ^= ENHOIMLIBJN.GetHashCode();
		}
		if (MEGCAGNHMIE != 0)
		{
			num ^= MEGCAGNHMIE.GetHashCode();
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
		if (FPKMKJEFLDE != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(FPKMKJEFLDE);
		}
		if (HADGAPLBEMO != 0.0)
		{
			output.WriteRawTag(17);
			output.WriteDouble(HADGAPLBEMO);
		}
		if (CGOABGKCBEF != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(CGOABGKCBEF);
		}
		if (ENHOIMLIBJN != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(ENHOIMLIBJN);
		}
		if (MEGCAGNHMIE != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(MEGCAGNHMIE);
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
		if (FPKMKJEFLDE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FPKMKJEFLDE);
		}
		if (HADGAPLBEMO != 0.0)
		{
			num += 9;
		}
		if (CGOABGKCBEF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CGOABGKCBEF);
		}
		if (ENHOIMLIBJN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ENHOIMLIBJN);
		}
		if (MEGCAGNHMIE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MEGCAGNHMIE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BAAHIGNNCIA other)
	{
		if (other != null)
		{
			if (other.FPKMKJEFLDE != 0)
			{
				FPKMKJEFLDE = other.FPKMKJEFLDE;
			}
			if (other.HADGAPLBEMO != 0.0)
			{
				HADGAPLBEMO = other.HADGAPLBEMO;
			}
			if (other.CGOABGKCBEF != 0)
			{
				CGOABGKCBEF = other.CGOABGKCBEF;
			}
			if (other.ENHOIMLIBJN != 0)
			{
				ENHOIMLIBJN = other.ENHOIMLIBJN;
			}
			if (other.MEGCAGNHMIE != 0)
			{
				MEGCAGNHMIE = other.MEGCAGNHMIE;
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
				FPKMKJEFLDE = input.ReadUInt32();
				break;
			case 17u:
				HADGAPLBEMO = input.ReadDouble();
				break;
			case 88u:
				CGOABGKCBEF = input.ReadUInt32();
				break;
			case 96u:
				ENHOIMLIBJN = input.ReadUInt32();
				break;
			case 104u:
				MEGCAGNHMIE = input.ReadUInt32();
				break;
			}
		}
	}
}
