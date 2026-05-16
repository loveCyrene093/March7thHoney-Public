using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AAHBECICOEN : IMessage<AAHBECICOEN>, IMessage, IEquatable<AAHBECICOEN>, IDeepCloneable<AAHBECICOEN>, IBufferMessage
{
	private static readonly MessageParser<AAHBECICOEN> _parser = new MessageParser<AAHBECICOEN>(() => new AAHBECICOEN());

	private UnknownFieldSet _unknownFields;

	public const int DJDKAIDIAADFieldNumber = 1;

	private LBDMFFDNFDP dJDKAIDIAAD_;

	public const int MapIdFieldNumber = 6;

	private uint mapId_;

	public const int EIIAGABAFECFieldNumber = 10;

	private uint eIIAGABAFEC_;

	public const int CPFCDOCJFBFFieldNumber = 15;

	private bool cPFCDOCJFBF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AAHBECICOEN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AAHBECICOENReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LBDMFFDNFDP DJDKAIDIAAD
	{
		get
		{
			return dJDKAIDIAAD_;
		}
		set
		{
			dJDKAIDIAAD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MapId
	{
		get
		{
			return mapId_;
		}
		set
		{
			mapId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EIIAGABAFEC
	{
		get
		{
			return eIIAGABAFEC_;
		}
		set
		{
			eIIAGABAFEC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CPFCDOCJFBF
	{
		get
		{
			return cPFCDOCJFBF_;
		}
		set
		{
			cPFCDOCJFBF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AAHBECICOEN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AAHBECICOEN(AAHBECICOEN other)
		: this()
	{
		dJDKAIDIAAD_ = other.dJDKAIDIAAD_;
		mapId_ = other.mapId_;
		eIIAGABAFEC_ = other.eIIAGABAFEC_;
		cPFCDOCJFBF_ = other.cPFCDOCJFBF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AAHBECICOEN Clone()
	{
		return new AAHBECICOEN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AAHBECICOEN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AAHBECICOEN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DJDKAIDIAAD != other.DJDKAIDIAAD)
		{
			return false;
		}
		if (MapId != other.MapId)
		{
			return false;
		}
		if (EIIAGABAFEC != other.EIIAGABAFEC)
		{
			return false;
		}
		if (CPFCDOCJFBF != other.CPFCDOCJFBF)
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
		if (DJDKAIDIAAD != LBDMFFDNFDP.Ghgapoakgab)
		{
			num ^= DJDKAIDIAAD.GetHashCode();
		}
		if (MapId != 0)
		{
			num ^= MapId.GetHashCode();
		}
		if (EIIAGABAFEC != 0)
		{
			num ^= EIIAGABAFEC.GetHashCode();
		}
		if (CPFCDOCJFBF)
		{
			num ^= CPFCDOCJFBF.GetHashCode();
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
		if (DJDKAIDIAAD != LBDMFFDNFDP.Ghgapoakgab)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)DJDKAIDIAAD);
		}
		if (MapId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(MapId);
		}
		if (EIIAGABAFEC != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(EIIAGABAFEC);
		}
		if (CPFCDOCJFBF)
		{
			output.WriteRawTag(120);
			output.WriteBool(CPFCDOCJFBF);
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
		if (DJDKAIDIAAD != LBDMFFDNFDP.Ghgapoakgab)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)DJDKAIDIAAD);
		}
		if (MapId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MapId);
		}
		if (EIIAGABAFEC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EIIAGABAFEC);
		}
		if (CPFCDOCJFBF)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AAHBECICOEN other)
	{
		if (other != null)
		{
			if (other.DJDKAIDIAAD != LBDMFFDNFDP.Ghgapoakgab)
			{
				DJDKAIDIAAD = other.DJDKAIDIAAD;
			}
			if (other.MapId != 0)
			{
				MapId = other.MapId;
			}
			if (other.EIIAGABAFEC != 0)
			{
				EIIAGABAFEC = other.EIIAGABAFEC;
			}
			if (other.CPFCDOCJFBF)
			{
				CPFCDOCJFBF = other.CPFCDOCJFBF;
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
				DJDKAIDIAAD = (LBDMFFDNFDP)input.ReadEnum();
				break;
			case 48u:
				MapId = input.ReadUInt32();
				break;
			case 80u:
				EIIAGABAFEC = input.ReadUInt32();
				break;
			case 120u:
				CPFCDOCJFBF = input.ReadBool();
				break;
			}
		}
	}
}
