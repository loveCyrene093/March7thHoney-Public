using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DLGEGGCHCID : IMessage<DLGEGGCHCID>, IMessage, IEquatable<DLGEGGCHCID>, IDeepCloneable<DLGEGGCHCID>, IBufferMessage
{
	private static readonly MessageParser<DLGEGGCHCID> _parser = new MessageParser<DLGEGGCHCID>(() => new DLGEGGCHCID());

	private UnknownFieldSet _unknownFields;

	public const int RoleStarFieldNumber = 8;

	private uint roleStar_;

	public const int PGNMDJIIKJBFieldNumber = 14;

	private static readonly FieldCodec<LHPPIAKKFME> _repeated_pGNMDJIIKJB_codec = FieldCodec.ForMessage(114u, LHPPIAKKFME.Parser);

	private readonly RepeatedField<LHPPIAKKFME> pGNMDJIIKJB_ = new RepeatedField<LHPPIAKKFME>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DLGEGGCHCID> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DLGEGGCHCIDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RoleStar
	{
		get
		{
			return roleStar_;
		}
		set
		{
			roleStar_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LHPPIAKKFME> PGNMDJIIKJB => pGNMDJIIKJB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLGEGGCHCID()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLGEGGCHCID(DLGEGGCHCID other)
		: this()
	{
		roleStar_ = other.roleStar_;
		pGNMDJIIKJB_ = other.pGNMDJIIKJB_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLGEGGCHCID Clone()
	{
		return new DLGEGGCHCID(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DLGEGGCHCID);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DLGEGGCHCID other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoleStar != other.RoleStar)
		{
			return false;
		}
		if (!pGNMDJIIKJB_.Equals(other.pGNMDJIIKJB_))
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
		if (RoleStar != 0)
		{
			num ^= RoleStar.GetHashCode();
		}
		num ^= pGNMDJIIKJB_.GetHashCode();
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
		if (RoleStar != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(RoleStar);
		}
		pGNMDJIIKJB_.WriteTo(ref output, _repeated_pGNMDJIIKJB_codec);
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
		if (RoleStar != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoleStar);
		}
		num += pGNMDJIIKJB_.CalculateSize(_repeated_pGNMDJIIKJB_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DLGEGGCHCID other)
	{
		if (other != null)
		{
			if (other.RoleStar != 0)
			{
				RoleStar = other.RoleStar;
			}
			pGNMDJIIKJB_.Add(other.pGNMDJIIKJB_);
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
				RoleStar = input.ReadUInt32();
				break;
			case 114u:
				pGNMDJIIKJB_.AddEntriesFrom(ref input, _repeated_pGNMDJIIKJB_codec);
				break;
			}
		}
	}
}
