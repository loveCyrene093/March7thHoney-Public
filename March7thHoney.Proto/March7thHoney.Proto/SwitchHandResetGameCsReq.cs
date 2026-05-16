using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SwitchHandResetGameCsReq : IMessage<SwitchHandResetGameCsReq>, IMessage, IEquatable<SwitchHandResetGameCsReq>, IDeepCloneable<SwitchHandResetGameCsReq>, IBufferMessage
{
	private static readonly MessageParser<SwitchHandResetGameCsReq> _parser = new MessageParser<SwitchHandResetGameCsReq>(() => new SwitchHandResetGameCsReq());

	private UnknownFieldSet _unknownFields;

	public const int CEIPHFIBPDKFieldNumber = 9;

	private GODHDEIPDJL cEIPHFIBPDK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SwitchHandResetGameCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SwitchHandResetGameCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GODHDEIPDJL CEIPHFIBPDK
	{
		get
		{
			return cEIPHFIBPDK_;
		}
		set
		{
			cEIPHFIBPDK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwitchHandResetGameCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwitchHandResetGameCsReq(SwitchHandResetGameCsReq other)
		: this()
	{
		cEIPHFIBPDK_ = ((other.cEIPHFIBPDK_ != null) ? other.cEIPHFIBPDK_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwitchHandResetGameCsReq Clone()
	{
		return new SwitchHandResetGameCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SwitchHandResetGameCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SwitchHandResetGameCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(CEIPHFIBPDK, other.CEIPHFIBPDK))
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
		if (cEIPHFIBPDK_ != null)
		{
			num ^= CEIPHFIBPDK.GetHashCode();
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
		if (cEIPHFIBPDK_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(CEIPHFIBPDK);
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
		if (cEIPHFIBPDK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CEIPHFIBPDK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SwitchHandResetGameCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.cEIPHFIBPDK_ != null)
		{
			if (cEIPHFIBPDK_ == null)
			{
				CEIPHFIBPDK = new GODHDEIPDJL();
			}
			CEIPHFIBPDK.MergeFrom(other.CEIPHFIBPDK);
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
			if (num != 74)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (cEIPHFIBPDK_ == null)
			{
				CEIPHFIBPDK = new GODHDEIPDJL();
			}
			input.ReadMessage(CEIPHFIBPDK);
		}
	}
}
