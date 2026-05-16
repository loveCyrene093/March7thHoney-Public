using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SwitchHandUpdateCsReq : IMessage<SwitchHandUpdateCsReq>, IMessage, IEquatable<SwitchHandUpdateCsReq>, IDeepCloneable<SwitchHandUpdateCsReq>, IBufferMessage
{
	private static readonly MessageParser<SwitchHandUpdateCsReq> _parser = new MessageParser<SwitchHandUpdateCsReq>(() => new SwitchHandUpdateCsReq());

	private UnknownFieldSet _unknownFields;

	public const int HKAEEMABJLAFieldNumber = 5;

	private GODHDEIPDJL hKAEEMABJLA_;

	public const int CNPILGNBDNBFieldNumber = 8;

	private HKLKGJCJJEB cNPILGNBDNB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SwitchHandUpdateCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SwitchHandUpdateCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GODHDEIPDJL HKAEEMABJLA
	{
		get
		{
			return hKAEEMABJLA_;
		}
		set
		{
			hKAEEMABJLA_ = value;
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
	public SwitchHandUpdateCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwitchHandUpdateCsReq(SwitchHandUpdateCsReq other)
		: this()
	{
		hKAEEMABJLA_ = ((other.hKAEEMABJLA_ != null) ? other.hKAEEMABJLA_.Clone() : null);
		cNPILGNBDNB_ = ((other.cNPILGNBDNB_ != null) ? other.cNPILGNBDNB_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwitchHandUpdateCsReq Clone()
	{
		return new SwitchHandUpdateCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SwitchHandUpdateCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SwitchHandUpdateCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(HKAEEMABJLA, other.HKAEEMABJLA))
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
		if (hKAEEMABJLA_ != null)
		{
			num ^= HKAEEMABJLA.GetHashCode();
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
		if (hKAEEMABJLA_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(HKAEEMABJLA);
		}
		if (cNPILGNBDNB_ != null)
		{
			output.WriteRawTag(66);
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
		if (hKAEEMABJLA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HKAEEMABJLA);
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
	public void MergeFrom(SwitchHandUpdateCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.hKAEEMABJLA_ != null)
		{
			if (hKAEEMABJLA_ == null)
			{
				HKAEEMABJLA = new GODHDEIPDJL();
			}
			HKAEEMABJLA.MergeFrom(other.HKAEEMABJLA);
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
				if (hKAEEMABJLA_ == null)
				{
					HKAEEMABJLA = new GODHDEIPDJL();
				}
				input.ReadMessage(HKAEEMABJLA);
				break;
			case 66u:
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
