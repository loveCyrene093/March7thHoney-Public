using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DailyFirstEnterMonopolyActivityScRsp : IMessage<DailyFirstEnterMonopolyActivityScRsp>, IMessage, IEquatable<DailyFirstEnterMonopolyActivityScRsp>, IDeepCloneable<DailyFirstEnterMonopolyActivityScRsp>, IBufferMessage
{
	private static readonly MessageParser<DailyFirstEnterMonopolyActivityScRsp> _parser = new MessageParser<DailyFirstEnterMonopolyActivityScRsp>(() => new DailyFirstEnterMonopolyActivityScRsp());

	private UnknownFieldSet _unknownFields;

	public const int EOBENDPKFBOFieldNumber = 3;

	private ODONLHDAPKB eOBENDPKFBO_;

	public const int LFGMMAPKDICFieldNumber = 4;

	private uint lFGMMAPKDIC_;

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	public const int LNEPHGMEJHJFieldNumber = 13;

	private bool lNEPHGMEJHJ_;

	public const int CILPIJNOIAGFieldNumber = 14;

	private long cILPIJNOIAG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DailyFirstEnterMonopolyActivityScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DailyFirstEnterMonopolyActivityScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ODONLHDAPKB EOBENDPKFBO
	{
		get
		{
			return eOBENDPKFBO_;
		}
		set
		{
			eOBENDPKFBO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LFGMMAPKDIC
	{
		get
		{
			return lFGMMAPKDIC_;
		}
		set
		{
			lFGMMAPKDIC_ = value;
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
	public bool LNEPHGMEJHJ
	{
		get
		{
			return lNEPHGMEJHJ_;
		}
		set
		{
			lNEPHGMEJHJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CILPIJNOIAG
	{
		get
		{
			return cILPIJNOIAG_;
		}
		set
		{
			cILPIJNOIAG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DailyFirstEnterMonopolyActivityScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DailyFirstEnterMonopolyActivityScRsp(DailyFirstEnterMonopolyActivityScRsp other)
		: this()
	{
		eOBENDPKFBO_ = ((other.eOBENDPKFBO_ != null) ? other.eOBENDPKFBO_.Clone() : null);
		lFGMMAPKDIC_ = other.lFGMMAPKDIC_;
		retcode_ = other.retcode_;
		lNEPHGMEJHJ_ = other.lNEPHGMEJHJ_;
		cILPIJNOIAG_ = other.cILPIJNOIAG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DailyFirstEnterMonopolyActivityScRsp Clone()
	{
		return new DailyFirstEnterMonopolyActivityScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DailyFirstEnterMonopolyActivityScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DailyFirstEnterMonopolyActivityScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(EOBENDPKFBO, other.EOBENDPKFBO))
		{
			return false;
		}
		if (LFGMMAPKDIC != other.LFGMMAPKDIC)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (LNEPHGMEJHJ != other.LNEPHGMEJHJ)
		{
			return false;
		}
		if (CILPIJNOIAG != other.CILPIJNOIAG)
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
		if (eOBENDPKFBO_ != null)
		{
			num ^= EOBENDPKFBO.GetHashCode();
		}
		if (LFGMMAPKDIC != 0)
		{
			num ^= LFGMMAPKDIC.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (LNEPHGMEJHJ)
		{
			num ^= LNEPHGMEJHJ.GetHashCode();
		}
		if (CILPIJNOIAG != 0L)
		{
			num ^= CILPIJNOIAG.GetHashCode();
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
		if (eOBENDPKFBO_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(EOBENDPKFBO);
		}
		if (LFGMMAPKDIC != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(LFGMMAPKDIC);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Retcode);
		}
		if (LNEPHGMEJHJ)
		{
			output.WriteRawTag(104);
			output.WriteBool(LNEPHGMEJHJ);
		}
		if (CILPIJNOIAG != 0L)
		{
			output.WriteRawTag(112);
			output.WriteInt64(CILPIJNOIAG);
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
		if (eOBENDPKFBO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EOBENDPKFBO);
		}
		if (LFGMMAPKDIC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LFGMMAPKDIC);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (LNEPHGMEJHJ)
		{
			num += 2;
		}
		if (CILPIJNOIAG != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(CILPIJNOIAG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DailyFirstEnterMonopolyActivityScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.eOBENDPKFBO_ != null)
		{
			if (eOBENDPKFBO_ == null)
			{
				EOBENDPKFBO = new ODONLHDAPKB();
			}
			EOBENDPKFBO.MergeFrom(other.EOBENDPKFBO);
		}
		if (other.LFGMMAPKDIC != 0)
		{
			LFGMMAPKDIC = other.LFGMMAPKDIC;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.LNEPHGMEJHJ)
		{
			LNEPHGMEJHJ = other.LNEPHGMEJHJ;
		}
		if (other.CILPIJNOIAG != 0L)
		{
			CILPIJNOIAG = other.CILPIJNOIAG;
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
				if (eOBENDPKFBO_ == null)
				{
					EOBENDPKFBO = new ODONLHDAPKB();
				}
				input.ReadMessage(EOBENDPKFBO);
				break;
			case 32u:
				LFGMMAPKDIC = input.ReadUInt32();
				break;
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			case 104u:
				LNEPHGMEJHJ = input.ReadBool();
				break;
			case 112u:
				CILPIJNOIAG = input.ReadInt64();
				break;
			}
		}
	}
}
