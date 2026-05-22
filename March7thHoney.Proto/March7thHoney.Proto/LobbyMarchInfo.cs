using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LobbyMarchInfo : IMessage<LobbyMarchInfo>, IMessage, IEquatable<LobbyMarchInfo>, IDeepCloneable<LobbyMarchInfo>, IBufferMessage
{
	private static readonly MessageParser<LobbyMarchInfo> _parser = new MessageParser<LobbyMarchInfo>(() => new LobbyMarchInfo());

	private UnknownFieldSet _unknownFields;

	public const int NLOCDHMLGJHFieldNumber = 1;

	private uint nLOCDHMLGJH_;

	public const int GIKABEMCFAOFieldNumber = 2;

	private bool gIKABEMCFAO_;

	public const int GJIKBFAHEAKFieldNumber = 3;

	private uint gJIKBFAHEAK_;

	public const int FBJPJKBDCLBFieldNumber = 4;

	private uint fBJPJKBDCLB_;

	public const int ONJKBENNMFCFieldNumber = 5;

	private GFNMAKHPAOE oNJKBENNMFC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LobbyMarchInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LobbyMarchInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NLOCDHMLGJH
	{
		get
		{
			return nLOCDHMLGJH_;
		}
		set
		{
			nLOCDHMLGJH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool GIKABEMCFAO
	{
		get
		{
			return gIKABEMCFAO_;
		}
		set
		{
			gIKABEMCFAO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GJIKBFAHEAK
	{
		get
		{
			return gJIKBFAHEAK_;
		}
		set
		{
			gJIKBFAHEAK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FBJPJKBDCLB
	{
		get
		{
			return fBJPJKBDCLB_;
		}
		set
		{
			fBJPJKBDCLB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFNMAKHPAOE ONJKBENNMFC
	{
		get
		{
			return oNJKBENNMFC_;
		}
		set
		{
			oNJKBENNMFC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyMarchInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyMarchInfo(LobbyMarchInfo other)
		: this()
	{
		nLOCDHMLGJH_ = other.nLOCDHMLGJH_;
		gIKABEMCFAO_ = other.gIKABEMCFAO_;
		gJIKBFAHEAK_ = other.gJIKBFAHEAK_;
		fBJPJKBDCLB_ = other.fBJPJKBDCLB_;
		oNJKBENNMFC_ = ((other.oNJKBENNMFC_ != null) ? other.oNJKBENNMFC_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyMarchInfo Clone()
	{
		return new LobbyMarchInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LobbyMarchInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LobbyMarchInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NLOCDHMLGJH != other.NLOCDHMLGJH)
		{
			return false;
		}
		if (GIKABEMCFAO != other.GIKABEMCFAO)
		{
			return false;
		}
		if (GJIKBFAHEAK != other.GJIKBFAHEAK)
		{
			return false;
		}
		if (FBJPJKBDCLB != other.FBJPJKBDCLB)
		{
			return false;
		}
		if (!object.Equals(ONJKBENNMFC, other.ONJKBENNMFC))
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
		if (NLOCDHMLGJH != 0)
		{
			num ^= NLOCDHMLGJH.GetHashCode();
		}
		if (GIKABEMCFAO)
		{
			num ^= GIKABEMCFAO.GetHashCode();
		}
		if (GJIKBFAHEAK != 0)
		{
			num ^= GJIKBFAHEAK.GetHashCode();
		}
		if (FBJPJKBDCLB != 0)
		{
			num ^= FBJPJKBDCLB.GetHashCode();
		}
		if (oNJKBENNMFC_ != null)
		{
			num ^= ONJKBENNMFC.GetHashCode();
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
		if (NLOCDHMLGJH != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(NLOCDHMLGJH);
		}
		if (GIKABEMCFAO)
		{
			output.WriteRawTag(16);
			output.WriteBool(GIKABEMCFAO);
		}
		if (GJIKBFAHEAK != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(GJIKBFAHEAK);
		}
		if (FBJPJKBDCLB != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(FBJPJKBDCLB);
		}
		if (oNJKBENNMFC_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(ONJKBENNMFC);
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
		if (NLOCDHMLGJH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NLOCDHMLGJH);
		}
		if (GIKABEMCFAO)
		{
			num += 2;
		}
		if (GJIKBFAHEAK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GJIKBFAHEAK);
		}
		if (FBJPJKBDCLB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FBJPJKBDCLB);
		}
		if (oNJKBENNMFC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ONJKBENNMFC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LobbyMarchInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.NLOCDHMLGJH != 0)
		{
			NLOCDHMLGJH = other.NLOCDHMLGJH;
		}
		if (other.GIKABEMCFAO)
		{
			GIKABEMCFAO = other.GIKABEMCFAO;
		}
		if (other.GJIKBFAHEAK != 0)
		{
			GJIKBFAHEAK = other.GJIKBFAHEAK;
		}
		if (other.FBJPJKBDCLB != 0)
		{
			FBJPJKBDCLB = other.FBJPJKBDCLB;
		}
		if (other.oNJKBENNMFC_ != null)
		{
			if (oNJKBENNMFC_ == null)
			{
				ONJKBENNMFC = new GFNMAKHPAOE();
			}
			ONJKBENNMFC.MergeFrom(other.ONJKBENNMFC);
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
				NLOCDHMLGJH = input.ReadUInt32();
				break;
			case 16u:
				GIKABEMCFAO = input.ReadBool();
				break;
			case 24u:
				GJIKBFAHEAK = input.ReadUInt32();
				break;
			case 32u:
				FBJPJKBDCLB = input.ReadUInt32();
				break;
			case 42u:
				if (oNJKBENNMFC_ == null)
				{
					ONJKBENNMFC = new GFNMAKHPAOE();
				}
				input.ReadMessage(ONJKBENNMFC);
				break;
			}
		}
	}
}
