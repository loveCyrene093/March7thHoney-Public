using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FPFFHGOKBNK : IMessage<FPFFHGOKBNK>, IMessage, IEquatable<FPFFHGOKBNK>, IDeepCloneable<FPFFHGOKBNK>, IBufferMessage
{
	private static readonly MessageParser<FPFFHGOKBNK> _parser = new MessageParser<FPFFHGOKBNK>(() => new FPFFHGOKBNK());

	private UnknownFieldSet _unknownFields;

	public const int EKDHCCEFJGAFieldNumber = 1;

	private static readonly FieldCodec<BattleAvatarServantInfo> _repeated_eKDHCCEFJGA_codec = FieldCodec.ForMessage(10u, BattleAvatarServantInfo.Parser);

	private readonly RepeatedField<BattleAvatarServantInfo> eKDHCCEFJGA_ = new RepeatedField<BattleAvatarServantInfo>();

	public const int JPKDNCPELDMFieldNumber = 2;

	private uint jPKDNCPELDM_;

	public const int PHJCDHKFNPJFieldNumber = 3;

	private uint pHJCDHKFNPJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FPFFHGOKBNK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FPFFHGOKBNKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleAvatarServantInfo> EKDHCCEFJGA => eKDHCCEFJGA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JPKDNCPELDM
	{
		get
		{
			return jPKDNCPELDM_;
		}
		set
		{
			jPKDNCPELDM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PHJCDHKFNPJ
	{
		get
		{
			return pHJCDHKFNPJ_;
		}
		set
		{
			pHJCDHKFNPJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FPFFHGOKBNK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FPFFHGOKBNK(FPFFHGOKBNK other)
		: this()
	{
		eKDHCCEFJGA_ = other.eKDHCCEFJGA_.Clone();
		jPKDNCPELDM_ = other.jPKDNCPELDM_;
		pHJCDHKFNPJ_ = other.pHJCDHKFNPJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FPFFHGOKBNK Clone()
	{
		return new FPFFHGOKBNK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FPFFHGOKBNK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FPFFHGOKBNK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!eKDHCCEFJGA_.Equals(other.eKDHCCEFJGA_))
		{
			return false;
		}
		if (JPKDNCPELDM != other.JPKDNCPELDM)
		{
			return false;
		}
		if (PHJCDHKFNPJ != other.PHJCDHKFNPJ)
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
		num ^= eKDHCCEFJGA_.GetHashCode();
		if (JPKDNCPELDM != 0)
		{
			num ^= JPKDNCPELDM.GetHashCode();
		}
		if (PHJCDHKFNPJ != 0)
		{
			num ^= PHJCDHKFNPJ.GetHashCode();
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
		eKDHCCEFJGA_.WriteTo(ref output, _repeated_eKDHCCEFJGA_codec);
		if (JPKDNCPELDM != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(JPKDNCPELDM);
		}
		if (PHJCDHKFNPJ != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(PHJCDHKFNPJ);
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
		num += eKDHCCEFJGA_.CalculateSize(_repeated_eKDHCCEFJGA_codec);
		if (JPKDNCPELDM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JPKDNCPELDM);
		}
		if (PHJCDHKFNPJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PHJCDHKFNPJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FPFFHGOKBNK other)
	{
		if (other != null)
		{
			eKDHCCEFJGA_.Add(other.eKDHCCEFJGA_);
			if (other.JPKDNCPELDM != 0)
			{
				JPKDNCPELDM = other.JPKDNCPELDM;
			}
			if (other.PHJCDHKFNPJ != 0)
			{
				PHJCDHKFNPJ = other.PHJCDHKFNPJ;
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
			case 10u:
				eKDHCCEFJGA_.AddEntriesFrom(ref input, _repeated_eKDHCCEFJGA_codec);
				break;
			case 16u:
				JPKDNCPELDM = input.ReadUInt32();
				break;
			case 24u:
				PHJCDHKFNPJ = input.ReadUInt32();
				break;
			}
		}
	}
}
