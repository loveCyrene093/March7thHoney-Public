using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DACJDMPICEL : IMessage<DACJDMPICEL>, IMessage, IEquatable<DACJDMPICEL>, IDeepCloneable<DACJDMPICEL>, IBufferMessage
{
	private static readonly MessageParser<DACJDMPICEL> _parser = new MessageParser<DACJDMPICEL>(() => new DACJDMPICEL());

	private UnknownFieldSet _unknownFields;

	public const int DamageFieldNumber = 1;

	private double damage_;

	public const int TraitIdFieldNumber = 4;

	private uint traitId_;

	public const int NKFDBEHPNLGFieldNumber = 15;

	private uint nKFDBEHPNLG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DACJDMPICEL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DACJDMPICELReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double Damage
	{
		get
		{
			return damage_;
		}
		set
		{
			damage_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TraitId
	{
		get
		{
			return traitId_;
		}
		set
		{
			traitId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NKFDBEHPNLG
	{
		get
		{
			return nKFDBEHPNLG_;
		}
		set
		{
			nKFDBEHPNLG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DACJDMPICEL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DACJDMPICEL(DACJDMPICEL other)
		: this()
	{
		damage_ = other.damage_;
		traitId_ = other.traitId_;
		nKFDBEHPNLG_ = other.nKFDBEHPNLG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DACJDMPICEL Clone()
	{
		return new DACJDMPICEL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DACJDMPICEL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DACJDMPICEL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Damage, other.Damage))
		{
			return false;
		}
		if (TraitId != other.TraitId)
		{
			return false;
		}
		if (NKFDBEHPNLG != other.NKFDBEHPNLG)
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
		if (Damage != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Damage);
		}
		if (TraitId != 0)
		{
			num ^= TraitId.GetHashCode();
		}
		if (NKFDBEHPNLG != 0)
		{
			num ^= NKFDBEHPNLG.GetHashCode();
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
		if (Damage != 0.0)
		{
			output.WriteRawTag(9);
			output.WriteDouble(Damage);
		}
		if (TraitId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(TraitId);
		}
		if (NKFDBEHPNLG != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(NKFDBEHPNLG);
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
		if (Damage != 0.0)
		{
			num += 9;
		}
		if (TraitId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TraitId);
		}
		if (NKFDBEHPNLG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NKFDBEHPNLG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DACJDMPICEL other)
	{
		if (other != null)
		{
			if (other.Damage != 0.0)
			{
				Damage = other.Damage;
			}
			if (other.TraitId != 0)
			{
				TraitId = other.TraitId;
			}
			if (other.NKFDBEHPNLG != 0)
			{
				NKFDBEHPNLG = other.NKFDBEHPNLG;
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
			case 9u:
				Damage = input.ReadDouble();
				break;
			case 32u:
				TraitId = input.ReadUInt32();
				break;
			case 120u:
				NKFDBEHPNLG = input.ReadUInt32();
				break;
			}
		}
	}
}
