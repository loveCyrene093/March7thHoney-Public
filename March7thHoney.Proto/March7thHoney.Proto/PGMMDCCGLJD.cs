using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PGMMDCCGLJD : IMessage<PGMMDCCGLJD>, IMessage, IEquatable<PGMMDCCGLJD>, IDeepCloneable<PGMMDCCGLJD>, IBufferMessage
{
	private static readonly MessageParser<PGMMDCCGLJD> _parser = new MessageParser<PGMMDCCGLJD>(() => new PGMMDCCGLJD());

	private UnknownFieldSet _unknownFields;

	public const int GKAONDBBDHFFieldNumber = 2;

	private static readonly MapField<uint, HHMDONEOEAK>.Codec _map_gKAONDBBDHF_codec = new MapField<uint, HHMDONEOEAK>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForMessage(18u, HHMDONEOEAK.Parser), 18u);

	private readonly MapField<uint, HHMDONEOEAK> gKAONDBBDHF_ = new MapField<uint, HHMDONEOEAK>();

	public const int PanelIdFieldNumber = 6;

	private uint panelId_;

	public const int OGHFMOALPEOFieldNumber = 10;

	private uint oGHFMOALPEO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PGMMDCCGLJD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PGMMDCCGLJDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, HHMDONEOEAK> GKAONDBBDHF => gKAONDBBDHF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PanelId
	{
		get
		{
			return panelId_;
		}
		set
		{
			panelId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OGHFMOALPEO
	{
		get
		{
			return oGHFMOALPEO_;
		}
		set
		{
			oGHFMOALPEO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PGMMDCCGLJD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PGMMDCCGLJD(PGMMDCCGLJD other)
		: this()
	{
		gKAONDBBDHF_ = other.gKAONDBBDHF_.Clone();
		panelId_ = other.panelId_;
		oGHFMOALPEO_ = other.oGHFMOALPEO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PGMMDCCGLJD Clone()
	{
		return new PGMMDCCGLJD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PGMMDCCGLJD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PGMMDCCGLJD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!GKAONDBBDHF.Equals(other.GKAONDBBDHF))
		{
			return false;
		}
		if (PanelId != other.PanelId)
		{
			return false;
		}
		if (OGHFMOALPEO != other.OGHFMOALPEO)
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
		num ^= GKAONDBBDHF.GetHashCode();
		if (PanelId != 0)
		{
			num ^= PanelId.GetHashCode();
		}
		if (OGHFMOALPEO != 0)
		{
			num ^= OGHFMOALPEO.GetHashCode();
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
		gKAONDBBDHF_.WriteTo(ref output, _map_gKAONDBBDHF_codec);
		if (PanelId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(PanelId);
		}
		if (OGHFMOALPEO != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(OGHFMOALPEO);
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
		num += gKAONDBBDHF_.CalculateSize(_map_gKAONDBBDHF_codec);
		if (PanelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PanelId);
		}
		if (OGHFMOALPEO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OGHFMOALPEO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PGMMDCCGLJD other)
	{
		if (other != null)
		{
			gKAONDBBDHF_.MergeFrom(other.gKAONDBBDHF_);
			if (other.PanelId != 0)
			{
				PanelId = other.PanelId;
			}
			if (other.OGHFMOALPEO != 0)
			{
				OGHFMOALPEO = other.OGHFMOALPEO;
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
			case 18u:
				gKAONDBBDHF_.AddEntriesFrom(ref input, _map_gKAONDBBDHF_codec);
				break;
			case 48u:
				PanelId = input.ReadUInt32();
				break;
			case 80u:
				OGHFMOALPEO = input.ReadUInt32();
				break;
			}
		}
	}
}
