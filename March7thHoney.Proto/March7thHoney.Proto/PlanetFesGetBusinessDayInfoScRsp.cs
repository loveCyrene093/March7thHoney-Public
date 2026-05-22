using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesGetBusinessDayInfoScRsp : IMessage<PlanetFesGetBusinessDayInfoScRsp>, IMessage, IEquatable<PlanetFesGetBusinessDayInfoScRsp>, IDeepCloneable<PlanetFesGetBusinessDayInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesGetBusinessDayInfoScRsp> _parser = new MessageParser<PlanetFesGetBusinessDayInfoScRsp>(() => new PlanetFesGetBusinessDayInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int ALIGEFKMMGHFieldNumber = 1;

	private long aLIGEFKMMGH_;

	public const int RetcodeFieldNumber = 12;

	private uint retcode_;

	public const int OADEJOMKKPFFieldNumber = 14;

	private PBGMKNEGOPK oADEJOMKKPF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesGetBusinessDayInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesGetBusinessDayInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long ALIGEFKMMGH
	{
		get
		{
			return aLIGEFKMMGH_;
		}
		set
		{
			aLIGEFKMMGH_ = value;
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
	public PBGMKNEGOPK OADEJOMKKPF
	{
		get
		{
			return oADEJOMKKPF_;
		}
		set
		{
			oADEJOMKKPF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesGetBusinessDayInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesGetBusinessDayInfoScRsp(PlanetFesGetBusinessDayInfoScRsp other)
		: this()
	{
		aLIGEFKMMGH_ = other.aLIGEFKMMGH_;
		retcode_ = other.retcode_;
		oADEJOMKKPF_ = ((other.oADEJOMKKPF_ != null) ? other.oADEJOMKKPF_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesGetBusinessDayInfoScRsp Clone()
	{
		return new PlanetFesGetBusinessDayInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesGetBusinessDayInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesGetBusinessDayInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ALIGEFKMMGH != other.ALIGEFKMMGH)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(OADEJOMKKPF, other.OADEJOMKKPF))
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
		if (ALIGEFKMMGH != 0L)
		{
			num ^= ALIGEFKMMGH.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (oADEJOMKKPF_ != null)
		{
			num ^= OADEJOMKKPF.GetHashCode();
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
		if (ALIGEFKMMGH != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(ALIGEFKMMGH);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Retcode);
		}
		if (oADEJOMKKPF_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(OADEJOMKKPF);
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
		if (ALIGEFKMMGH != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(ALIGEFKMMGH);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (oADEJOMKKPF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OADEJOMKKPF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesGetBusinessDayInfoScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ALIGEFKMMGH != 0L)
		{
			ALIGEFKMMGH = other.ALIGEFKMMGH;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.oADEJOMKKPF_ != null)
		{
			if (oADEJOMKKPF_ == null)
			{
				OADEJOMKKPF = new PBGMKNEGOPK();
			}
			OADEJOMKKPF.MergeFrom(other.OADEJOMKKPF);
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
			case 8u:
				ALIGEFKMMGH = input.ReadInt64();
				break;
			case 96u:
				Retcode = input.ReadUInt32();
				break;
			case 114u:
				if (oADEJOMKKPF_ == null)
				{
					OADEJOMKKPF = new PBGMKNEGOPK();
				}
				input.ReadMessage(OADEJOMKKPF);
				break;
			}
		}
	}
}
