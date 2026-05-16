using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueTournTitanUpdateTitanBlessProgressScNotify : IMessage<RogueTournTitanUpdateTitanBlessProgressScNotify>, IMessage, IEquatable<RogueTournTitanUpdateTitanBlessProgressScNotify>, IDeepCloneable<RogueTournTitanUpdateTitanBlessProgressScNotify>, IBufferMessage
{
	private static readonly MessageParser<RogueTournTitanUpdateTitanBlessProgressScNotify> _parser = new MessageParser<RogueTournTitanUpdateTitanBlessProgressScNotify>(() => new RogueTournTitanUpdateTitanBlessProgressScNotify());

	private UnknownFieldSet _unknownFields;

	public const int IEINECPHOFLFieldNumber = 13;

	private uint iEINECPHOFL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueTournTitanUpdateTitanBlessProgressScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueTournTitanUpdateTitanBlessProgressScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IEINECPHOFL
	{
		get
		{
			return iEINECPHOFL_;
		}
		set
		{
			iEINECPHOFL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournTitanUpdateTitanBlessProgressScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournTitanUpdateTitanBlessProgressScNotify(RogueTournTitanUpdateTitanBlessProgressScNotify other)
		: this()
	{
		iEINECPHOFL_ = other.iEINECPHOFL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournTitanUpdateTitanBlessProgressScNotify Clone()
	{
		return new RogueTournTitanUpdateTitanBlessProgressScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueTournTitanUpdateTitanBlessProgressScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueTournTitanUpdateTitanBlessProgressScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IEINECPHOFL != other.IEINECPHOFL)
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
		if (IEINECPHOFL != 0)
		{
			num ^= IEINECPHOFL.GetHashCode();
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
		if (IEINECPHOFL != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(IEINECPHOFL);
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
		if (IEINECPHOFL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IEINECPHOFL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueTournTitanUpdateTitanBlessProgressScNotify other)
	{
		if (other != null)
		{
			if (other.IEINECPHOFL != 0)
			{
				IEINECPHOFL = other.IEINECPHOFL;
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
			if (num != 104)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				IEINECPHOFL = input.ReadUInt32();
			}
		}
	}
}
