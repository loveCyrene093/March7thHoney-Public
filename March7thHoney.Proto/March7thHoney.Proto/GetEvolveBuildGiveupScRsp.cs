using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetEvolveBuildGiveupScRsp : IMessage<GetEvolveBuildGiveupScRsp>, IMessage, IEquatable<GetEvolveBuildGiveupScRsp>, IDeepCloneable<GetEvolveBuildGiveupScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetEvolveBuildGiveupScRsp> _parser = new MessageParser<GetEvolveBuildGiveupScRsp>(() => new GetEvolveBuildGiveupScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 3;

	private uint retcode_;

	public const int MODDIBHCPPDFieldNumber = 6;

	private CJLJDKLCNDA mODDIBHCPPD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetEvolveBuildGiveupScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetEvolveBuildGiveupScRspReflection.Descriptor.MessageTypes[0];

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
	public CJLJDKLCNDA MODDIBHCPPD
	{
		get
		{
			return mODDIBHCPPD_;
		}
		set
		{
			mODDIBHCPPD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetEvolveBuildGiveupScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetEvolveBuildGiveupScRsp(GetEvolveBuildGiveupScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		mODDIBHCPPD_ = ((other.mODDIBHCPPD_ != null) ? other.mODDIBHCPPD_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetEvolveBuildGiveupScRsp Clone()
	{
		return new GetEvolveBuildGiveupScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetEvolveBuildGiveupScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetEvolveBuildGiveupScRsp other)
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
		if (!object.Equals(MODDIBHCPPD, other.MODDIBHCPPD))
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
		if (mODDIBHCPPD_ != null)
		{
			num ^= MODDIBHCPPD.GetHashCode();
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
			output.WriteRawTag(24);
			output.WriteUInt32(Retcode);
		}
		if (mODDIBHCPPD_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(MODDIBHCPPD);
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
		if (mODDIBHCPPD_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MODDIBHCPPD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetEvolveBuildGiveupScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.mODDIBHCPPD_ != null)
		{
			if (mODDIBHCPPD_ == null)
			{
				MODDIBHCPPD = new CJLJDKLCNDA();
			}
			MODDIBHCPPD.MergeFrom(other.MODDIBHCPPD);
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
				Retcode = input.ReadUInt32();
				break;
			case 50u:
				if (mODDIBHCPPD_ == null)
				{
					MODDIBHCPPD = new CJLJDKLCNDA();
				}
				input.ReadMessage(MODDIBHCPPD);
				break;
			}
		}
	}
}
