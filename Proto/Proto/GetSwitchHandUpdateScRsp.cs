using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetSwitchHandUpdateScRsp : IMessage<GetSwitchHandUpdateScRsp>, IMessage, IEquatable<GetSwitchHandUpdateScRsp>, IDeepCloneable<GetSwitchHandUpdateScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetSwitchHandUpdateScRsp> _parser = new MessageParser<GetSwitchHandUpdateScRsp>(() => new GetSwitchHandUpdateScRsp());

	private UnknownFieldSet _unknownFields;

	public const int OMHAENBIKCNFieldNumber = 5;

	private GODHDEIPDJL oMHAENBIKCN_;

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	public const int CNPILGNBDNBFieldNumber = 14;

	private HKLKGJCJJEB cNPILGNBDNB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetSwitchHandUpdateScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetSwitchHandUpdateScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GODHDEIPDJL OMHAENBIKCN
	{
		get
		{
			return oMHAENBIKCN_;
		}
		set
		{
			oMHAENBIKCN_ = value;
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
	public HKLKGJCJJEB CNPILGNBDNB
	{
		get
		{
			return cNPILGNBDNB_;
		}
		set
		{
			cNPILGNBDNB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetSwitchHandUpdateScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetSwitchHandUpdateScRsp(GetSwitchHandUpdateScRsp other)
		: this()
	{
		oMHAENBIKCN_ = ((other.oMHAENBIKCN_ != null) ? other.oMHAENBIKCN_.Clone() : null);
		retcode_ = other.retcode_;
		cNPILGNBDNB_ = ((other.cNPILGNBDNB_ != null) ? other.cNPILGNBDNB_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetSwitchHandUpdateScRsp Clone()
	{
		return new GetSwitchHandUpdateScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetSwitchHandUpdateScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetSwitchHandUpdateScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(OMHAENBIKCN, other.OMHAENBIKCN))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(CNPILGNBDNB, other.CNPILGNBDNB))
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
		if (oMHAENBIKCN_ != null)
		{
			num ^= OMHAENBIKCN.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (cNPILGNBDNB_ != null)
		{
			num ^= CNPILGNBDNB.GetHashCode();
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
		if (oMHAENBIKCN_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(OMHAENBIKCN);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Retcode);
		}
		if (cNPILGNBDNB_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(CNPILGNBDNB);
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
		if (oMHAENBIKCN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OMHAENBIKCN);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (cNPILGNBDNB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CNPILGNBDNB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetSwitchHandUpdateScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.oMHAENBIKCN_ != null)
		{
			if (oMHAENBIKCN_ == null)
			{
				OMHAENBIKCN = new GODHDEIPDJL();
			}
			OMHAENBIKCN.MergeFrom(other.OMHAENBIKCN);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.cNPILGNBDNB_ != null)
		{
			if (cNPILGNBDNB_ == null)
			{
				CNPILGNBDNB = new HKLKGJCJJEB();
			}
			CNPILGNBDNB.MergeFrom(other.CNPILGNBDNB);
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
			case 42u:
				if (oMHAENBIKCN_ == null)
				{
					OMHAENBIKCN = new GODHDEIPDJL();
				}
				input.ReadMessage(OMHAENBIKCN);
				break;
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			case 114u:
				if (cNPILGNBDNB_ == null)
				{
					CNPILGNBDNB = new HKLKGJCJJEB();
				}
				input.ReadMessage(CNPILGNBDNB);
				break;
			}
		}
	}
}
