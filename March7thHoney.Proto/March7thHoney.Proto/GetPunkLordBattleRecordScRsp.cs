using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetPunkLordBattleRecordScRsp : IMessage<GetPunkLordBattleRecordScRsp>, IMessage, IEquatable<GetPunkLordBattleRecordScRsp>, IDeepCloneable<GetPunkLordBattleRecordScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetPunkLordBattleRecordScRsp> _parser = new MessageParser<GetPunkLordBattleRecordScRsp>(() => new GetPunkLordBattleRecordScRsp());

	private UnknownFieldSet _unknownFields;

	public const int PACIODONHGJFieldNumber = 3;

	private static readonly FieldCodec<TryDownLoadReplay> _repeated_pACIODONHGJ_codec = FieldCodec.ForMessage(26u, TryDownLoadReplay.Parser);

	private readonly RepeatedField<TryDownLoadReplay> pACIODONHGJ_ = new RepeatedField<TryDownLoadReplay>();

	public const int JIPALBLOPFIFieldNumber = 4;

	private JLLIDDIBOHI jIPALBLOPFI_;

	public const int DFIDPJEIBJKFieldNumber = 8;

	private static readonly FieldCodec<PHOCECJOBHH> _repeated_dFIDPJEIBJK_codec = FieldCodec.ForMessage(66u, PHOCECJOBHH.Parser);

	private readonly RepeatedField<PHOCECJOBHH> dFIDPJEIBJK_ = new RepeatedField<PHOCECJOBHH>();

	public const int RetcodeFieldNumber = 12;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetPunkLordBattleRecordScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetPunkLordBattleRecordScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<TryDownLoadReplay> PACIODONHGJ => pACIODONHGJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JLLIDDIBOHI JIPALBLOPFI
	{
		get
		{
			return jIPALBLOPFI_;
		}
		set
		{
			jIPALBLOPFI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PHOCECJOBHH> DFIDPJEIBJK => dFIDPJEIBJK_;

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
	public GetPunkLordBattleRecordScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetPunkLordBattleRecordScRsp(GetPunkLordBattleRecordScRsp other)
		: this()
	{
		pACIODONHGJ_ = other.pACIODONHGJ_.Clone();
		jIPALBLOPFI_ = ((other.jIPALBLOPFI_ != null) ? other.jIPALBLOPFI_.Clone() : null);
		dFIDPJEIBJK_ = other.dFIDPJEIBJK_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetPunkLordBattleRecordScRsp Clone()
	{
		return new GetPunkLordBattleRecordScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetPunkLordBattleRecordScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetPunkLordBattleRecordScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!pACIODONHGJ_.Equals(other.pACIODONHGJ_))
		{
			return false;
		}
		if (!object.Equals(JIPALBLOPFI, other.JIPALBLOPFI))
		{
			return false;
		}
		if (!dFIDPJEIBJK_.Equals(other.dFIDPJEIBJK_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		num ^= pACIODONHGJ_.GetHashCode();
		if (jIPALBLOPFI_ != null)
		{
			num ^= JIPALBLOPFI.GetHashCode();
		}
		num ^= dFIDPJEIBJK_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		pACIODONHGJ_.WriteTo(ref output, _repeated_pACIODONHGJ_codec);
		if (jIPALBLOPFI_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(JIPALBLOPFI);
		}
		dFIDPJEIBJK_.WriteTo(ref output, _repeated_dFIDPJEIBJK_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Retcode);
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
		num += pACIODONHGJ_.CalculateSize(_repeated_pACIODONHGJ_codec);
		if (jIPALBLOPFI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JIPALBLOPFI);
		}
		num += dFIDPJEIBJK_.CalculateSize(_repeated_dFIDPJEIBJK_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetPunkLordBattleRecordScRsp other)
	{
		if (other == null)
		{
			return;
		}
		pACIODONHGJ_.Add(other.pACIODONHGJ_);
		if (other.jIPALBLOPFI_ != null)
		{
			if (jIPALBLOPFI_ == null)
			{
				JIPALBLOPFI = new JLLIDDIBOHI();
			}
			JIPALBLOPFI.MergeFrom(other.JIPALBLOPFI);
		}
		dFIDPJEIBJK_.Add(other.dFIDPJEIBJK_);
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
			case 26u:
				pACIODONHGJ_.AddEntriesFrom(ref input, _repeated_pACIODONHGJ_codec);
				break;
			case 34u:
				if (jIPALBLOPFI_ == null)
				{
					JIPALBLOPFI = new JLLIDDIBOHI();
				}
				input.ReadMessage(JIPALBLOPFI);
				break;
			case 66u:
				dFIDPJEIBJK_.AddEntriesFrom(ref input, _repeated_dFIDPJEIBJK_codec);
				break;
			case 96u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
