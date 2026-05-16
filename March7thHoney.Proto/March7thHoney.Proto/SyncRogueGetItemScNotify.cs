using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SyncRogueGetItemScNotify : IMessage<SyncRogueGetItemScNotify>, IMessage, IEquatable<SyncRogueGetItemScNotify>, IDeepCloneable<SyncRogueGetItemScNotify>, IBufferMessage
{
	private static readonly MessageParser<SyncRogueGetItemScNotify> _parser = new MessageParser<SyncRogueGetItemScNotify>(() => new SyncRogueGetItemScNotify());

	private UnknownFieldSet _unknownFields;

	public const int IOHAONFDLKEFieldNumber = 8;

	private ItemList iOHAONFDLKE_;

	public const int GetItemListFieldNumber = 14;

	private ItemList getItemList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SyncRogueGetItemScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SyncRogueGetItemScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList IOHAONFDLKE
	{
		get
		{
			return iOHAONFDLKE_;
		}
		set
		{
			iOHAONFDLKE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList GetItemList
	{
		get
		{
			return getItemList_;
		}
		set
		{
			getItemList_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueGetItemScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueGetItemScNotify(SyncRogueGetItemScNotify other)
		: this()
	{
		iOHAONFDLKE_ = ((other.iOHAONFDLKE_ != null) ? other.iOHAONFDLKE_.Clone() : null);
		getItemList_ = ((other.getItemList_ != null) ? other.getItemList_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueGetItemScNotify Clone()
	{
		return new SyncRogueGetItemScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SyncRogueGetItemScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SyncRogueGetItemScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(IOHAONFDLKE, other.IOHAONFDLKE))
		{
			return false;
		}
		if (!object.Equals(GetItemList, other.GetItemList))
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
		if (iOHAONFDLKE_ != null)
		{
			num ^= IOHAONFDLKE.GetHashCode();
		}
		if (getItemList_ != null)
		{
			num ^= GetItemList.GetHashCode();
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
		if (iOHAONFDLKE_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(IOHAONFDLKE);
		}
		if (getItemList_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(GetItemList);
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
		if (iOHAONFDLKE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IOHAONFDLKE);
		}
		if (getItemList_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GetItemList);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SyncRogueGetItemScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.iOHAONFDLKE_ != null)
		{
			if (iOHAONFDLKE_ == null)
			{
				IOHAONFDLKE = new ItemList();
			}
			IOHAONFDLKE.MergeFrom(other.IOHAONFDLKE);
		}
		if (other.getItemList_ != null)
		{
			if (getItemList_ == null)
			{
				GetItemList = new ItemList();
			}
			GetItemList.MergeFrom(other.GetItemList);
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
			case 66u:
				if (iOHAONFDLKE_ == null)
				{
					IOHAONFDLKE = new ItemList();
				}
				input.ReadMessage(IOHAONFDLKE);
				break;
			case 114u:
				if (getItemList_ == null)
				{
					GetItemList = new ItemList();
				}
				input.ReadMessage(GetItemList);
				break;
			}
		}
	}
}
