using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetMonopolyDailyReportScRsp : IMessage<GetMonopolyDailyReportScRsp>, IMessage, IEquatable<GetMonopolyDailyReportScRsp>, IDeepCloneable<GetMonopolyDailyReportScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetMonopolyDailyReportScRsp> _parser = new MessageParser<GetMonopolyDailyReportScRsp>(() => new GetMonopolyDailyReportScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 7;

	private uint retcode_;

	public const int EOBENDPKFBOFieldNumber = 11;

	private ODONLHDAPKB eOBENDPKFBO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetMonopolyDailyReportScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetMonopolyDailyReportScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public GetMonopolyDailyReportScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMonopolyDailyReportScRsp(GetMonopolyDailyReportScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		eOBENDPKFBO_ = ((other.eOBENDPKFBO_ != null) ? other.eOBENDPKFBO_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMonopolyDailyReportScRsp Clone()
	{
		return new GetMonopolyDailyReportScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetMonopolyDailyReportScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetMonopolyDailyReportScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(EOBENDPKFBO, other.EOBENDPKFBO))
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (eOBENDPKFBO_ != null)
		{
			num ^= EOBENDPKFBO.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Retcode);
		}
		if (eOBENDPKFBO_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(EOBENDPKFBO);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (eOBENDPKFBO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EOBENDPKFBO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetMonopolyDailyReportScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.eOBENDPKFBO_ != null)
		{
			if (eOBENDPKFBO_ == null)
			{
				EOBENDPKFBO = new ODONLHDAPKB();
			}
			EOBENDPKFBO.MergeFrom(other.EOBENDPKFBO);
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
			case 56u:
				Retcode = input.ReadUInt32();
				break;
			case 90u:
				if (eOBENDPKFBO_ == null)
				{
					EOBENDPKFBO = new ODONLHDAPKB();
				}
				input.ReadMessage(EOBENDPKFBO);
				break;
			}
		}
	}
}
