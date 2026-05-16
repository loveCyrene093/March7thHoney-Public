using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NCIFDEHCMBK : IMessage<NCIFDEHCMBK>, IMessage, IEquatable<NCIFDEHCMBK>, IDeepCloneable<NCIFDEHCMBK>, IBufferMessage
{
	private static readonly MessageParser<NCIFDEHCMBK> _parser = new MessageParser<NCIFDEHCMBK>(() => new NCIFDEHCMBK());

	private UnknownFieldSet _unknownFields;

	public const int AJANDPBFECKFieldNumber = 3;

	private bool aJANDPBFECK_;

	public const int AGJMPNMLEGNFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_aGJMPNMLEGN_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> aGJMPNMLEGN_ = new RepeatedField<uint>();

	public const int NMKJBKCEIGPFieldNumber = 5;

	private uint nMKJBKCEIGP_;

	public const int IHDMLHFAEKHFieldNumber = 13;

	private CIGKBDIGGOI iHDMLHFAEKH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NCIFDEHCMBK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NCIFDEHCMBKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool AJANDPBFECK
	{
		get
		{
			return aJANDPBFECK_;
		}
		set
		{
			aJANDPBFECK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AGJMPNMLEGN => aGJMPNMLEGN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NMKJBKCEIGP
	{
		get
		{
			return nMKJBKCEIGP_;
		}
		set
		{
			nMKJBKCEIGP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIGKBDIGGOI IHDMLHFAEKH
	{
		get
		{
			return iHDMLHFAEKH_;
		}
		set
		{
			iHDMLHFAEKH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NCIFDEHCMBK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NCIFDEHCMBK(NCIFDEHCMBK other)
		: this()
	{
		aJANDPBFECK_ = other.aJANDPBFECK_;
		aGJMPNMLEGN_ = other.aGJMPNMLEGN_.Clone();
		nMKJBKCEIGP_ = other.nMKJBKCEIGP_;
		iHDMLHFAEKH_ = ((other.iHDMLHFAEKH_ != null) ? other.iHDMLHFAEKH_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NCIFDEHCMBK Clone()
	{
		return new NCIFDEHCMBK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NCIFDEHCMBK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NCIFDEHCMBK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AJANDPBFECK != other.AJANDPBFECK)
		{
			return false;
		}
		if (!aGJMPNMLEGN_.Equals(other.aGJMPNMLEGN_))
		{
			return false;
		}
		if (NMKJBKCEIGP != other.NMKJBKCEIGP)
		{
			return false;
		}
		if (!object.Equals(IHDMLHFAEKH, other.IHDMLHFAEKH))
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
		if (AJANDPBFECK)
		{
			num ^= AJANDPBFECK.GetHashCode();
		}
		num ^= aGJMPNMLEGN_.GetHashCode();
		if (NMKJBKCEIGP != 0)
		{
			num ^= NMKJBKCEIGP.GetHashCode();
		}
		if (iHDMLHFAEKH_ != null)
		{
			num ^= IHDMLHFAEKH.GetHashCode();
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
		if (AJANDPBFECK)
		{
			output.WriteRawTag(24);
			output.WriteBool(AJANDPBFECK);
		}
		aGJMPNMLEGN_.WriteTo(ref output, _repeated_aGJMPNMLEGN_codec);
		if (NMKJBKCEIGP != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(NMKJBKCEIGP);
		}
		if (iHDMLHFAEKH_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(IHDMLHFAEKH);
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
		if (AJANDPBFECK)
		{
			num += 2;
		}
		num += aGJMPNMLEGN_.CalculateSize(_repeated_aGJMPNMLEGN_codec);
		if (NMKJBKCEIGP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NMKJBKCEIGP);
		}
		if (iHDMLHFAEKH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IHDMLHFAEKH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NCIFDEHCMBK other)
	{
		if (other == null)
		{
			return;
		}
		if (other.AJANDPBFECK)
		{
			AJANDPBFECK = other.AJANDPBFECK;
		}
		aGJMPNMLEGN_.Add(other.aGJMPNMLEGN_);
		if (other.NMKJBKCEIGP != 0)
		{
			NMKJBKCEIGP = other.NMKJBKCEIGP;
		}
		if (other.iHDMLHFAEKH_ != null)
		{
			if (iHDMLHFAEKH_ == null)
			{
				IHDMLHFAEKH = new CIGKBDIGGOI();
			}
			IHDMLHFAEKH.MergeFrom(other.IHDMLHFAEKH);
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
			case 24u:
				AJANDPBFECK = input.ReadBool();
				break;
			case 32u:
			case 34u:
				aGJMPNMLEGN_.AddEntriesFrom(ref input, _repeated_aGJMPNMLEGN_codec);
				break;
			case 40u:
				NMKJBKCEIGP = input.ReadUInt32();
				break;
			case 106u:
				if (iHDMLHFAEKH_ == null)
				{
					IHDMLHFAEKH = new CIGKBDIGGOI();
				}
				input.ReadMessage(IHDMLHFAEKH);
				break;
			}
		}
	}
}
