using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SyncRechargeBenefitInfoScNotify : IMessage<SyncRechargeBenefitInfoScNotify>, IMessage, IEquatable<SyncRechargeBenefitInfoScNotify>, IDeepCloneable<SyncRechargeBenefitInfoScNotify>, IBufferMessage
{
	private static readonly MessageParser<SyncRechargeBenefitInfoScNotify> _parser = new MessageParser<SyncRechargeBenefitInfoScNotify>(() => new SyncRechargeBenefitInfoScNotify());

	private UnknownFieldSet _unknownFields;

	public const int FIFHCICHDOHFieldNumber = 11;

	private DHKCDCCHLHP fIFHCICHDOH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SyncRechargeBenefitInfoScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SyncRechargeBenefitInfoScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DHKCDCCHLHP FIFHCICHDOH
	{
		get
		{
			return fIFHCICHDOH_;
		}
		set
		{
			fIFHCICHDOH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRechargeBenefitInfoScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRechargeBenefitInfoScNotify(SyncRechargeBenefitInfoScNotify other)
		: this()
	{
		fIFHCICHDOH_ = ((other.fIFHCICHDOH_ != null) ? other.fIFHCICHDOH_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRechargeBenefitInfoScNotify Clone()
	{
		return new SyncRechargeBenefitInfoScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SyncRechargeBenefitInfoScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SyncRechargeBenefitInfoScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(FIFHCICHDOH, other.FIFHCICHDOH))
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
		if (fIFHCICHDOH_ != null)
		{
			num ^= FIFHCICHDOH.GetHashCode();
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
		if (fIFHCICHDOH_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(FIFHCICHDOH);
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
		if (fIFHCICHDOH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FIFHCICHDOH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SyncRechargeBenefitInfoScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.fIFHCICHDOH_ != null)
		{
			if (fIFHCICHDOH_ == null)
			{
				FIFHCICHDOH = new DHKCDCCHLHP();
			}
			FIFHCICHDOH.MergeFrom(other.FIFHCICHDOH);
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
			if (num != 90)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (fIFHCICHDOH_ == null)
			{
				FIFHCICHDOH = new DHKCDCCHLHP();
			}
			input.ReadMessage(FIFHCICHDOH);
		}
	}
}
